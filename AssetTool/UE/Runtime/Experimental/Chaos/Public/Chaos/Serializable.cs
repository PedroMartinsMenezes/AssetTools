using static AssetTool.Chaos.Chaos;

namespace AssetTool.Chaos
{
    public class TSerializablePtr<T> : ITransferable where T : ITransferable
    {
        public FBool bExists;
        public int32 Tag;
        public EImplicitObjectType ObjectType;
        public FImplicitObject ImplicitObject;
        public FBVHParticles BVHParticles;

        [Location("void SerializePtr(TSerializablePtr<T>& Obj)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref bExists);
            if (!bExists)
                return this;
            transfer.Move(ref Tag);
            StaticSerialize(transfer);
            return this;
        }

        [Location("void StaticSerialize(TSerializablePtr<T>& Serializable)")]
        private void StaticSerialize(Transfer transfer)
        {
            if (typeof(FImplicitObject).IsAssignableFrom(typeof(T)))
            {
                transfer.MoveEnum(ref ObjectType);
                ImplicitObject ??= FImplicitObjectSerializationFactory(transfer);
                transfer.Move(ref ImplicitObject);
            }
            else if (typeof(FBVHParticles).IsAssignableFrom(typeof(T)))
            {
                BVHParticles ??= new();
                transfer.Move(ref BVHParticles);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        [Location("FImplicitObject* FImplicitObject::SerializationFactory(FChaosArchive& Ar, FImplicitObject* Obj)")]
        private FImplicitObject FImplicitObjectSerializationFactory(Transfer transfer)
        {
            if (transfer.Supports.ScaledGeometryIsConcrete)
            {
                if (IsScaled(ObjectType))
                {
                    EImplicitObjectType InnerType = GetInnerType(ObjectType);
                    switch (InnerType)
                    {
                        case EImplicitObjectType.Convex: return new TImplicitObjectScaled<FConvex>();
                        case EImplicitObjectType.TriangleMesh: return new TImplicitObjectScaled<FTriangleMeshImplicitObject>();
                    }
                    return default;
                }
            }

            if (IsInstanced(ObjectType))
            {
                EImplicitObjectType InnerType = GetInnerType(ObjectType);
                switch (InnerType)
                {
                    case EImplicitObjectType.Convex: return new TImplicitObjectInstanced<FConvex>();
                    case EImplicitObjectType.TriangleMesh: return new TImplicitObjectInstanced<FTriangleMeshImplicitObject>();
                }
                return default;
            }

            switch (ObjectType)
            {
                case EImplicitObjectType.Sphere: return new TSphere3();
                case EImplicitObjectType.Box: return new TBox3();
                case EImplicitObjectType.Plane: return new TPlane3();
                case EImplicitObjectType.Capsule: return new FCapsule();
                case EImplicitObjectType.Transformed: return new TImplicitObjectTransformed3<TDouble>();
                case EImplicitObjectType.Union: return new FImplicitObjectUnion();
                case EImplicitObjectType.UnionClustered: return new FImplicitObjectUnionClustered();
                case EImplicitObjectType.LevelSet: return new FLevelSet();
                case EImplicitObjectType.Convex: return new FConvex();
                case EImplicitObjectType.TaperedCylinder: return new FTaperedCylinder();
                case EImplicitObjectType.TaperedCapsule: return new FTaperedCapsule();
                case EImplicitObjectType.TriangleMesh: return new FTriangleMeshImplicitObject();
                case EImplicitObjectType.DEPRECATED_Scaled: return !transfer.Supports.ScaledGeometryIsConcrete ? new TImplicitObjectScaled<FImplicitObject>() : default;
                case EImplicitObjectType.HeightField: return new FHeightField();
                case EImplicitObjectType.Cylinder: return new FCylinder();
            }

            return default;
        }
    }
}

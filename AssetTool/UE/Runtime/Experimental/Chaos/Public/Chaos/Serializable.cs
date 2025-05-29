using static AssetTool.Chaos;

namespace AssetTool
{
    public class TSerializablePtr<T> : ITransferible where T : ITransferible, new()
    {
        public FBool bExists;
        public int32 Tag;
        public EImplicitObjectType ObjectType;
        public ITransferible Object;

        [Location("void SerializePtr(TSerializablePtr<T>& Obj)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref bExists);
            transfer.Move(ref Tag);
            StaticSerialize(transfer);
            return this;
        }

        [Location("void StaticSerialize(TSerializablePtr<T>& Serializable)")]
        private void StaticSerialize(Transfer transfer)
        {
            Object ??= SerializationFactory(transfer);
            if (Object is { })
            {
                transfer.Move(ref Object);
            }
        }

        [Location("FImplicitObject* FImplicitObject::SerializationFactory(FChaosArchive& Ar, FImplicitObject* Obj)")]
        private ITransferible SerializationFactory(Transfer transfer)
        {
            ObjectType = (EImplicitObjectType)transfer.Move((byte)ObjectType);

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
                    return null;
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
                return null;
            }

            switch (ObjectType)
            {
                case EImplicitObjectType.Sphere: return new TSphere3<TDouble>();
                case EImplicitObjectType.Box: return new TBox3<TDouble>();
                case EImplicitObjectType.Plane: return new TPlane3<TDouble>();
                case EImplicitObjectType.Capsule: return new FCapsule();
                case EImplicitObjectType.Transformed: return new TImplicitObjectTransformed3<TDouble>();
                case EImplicitObjectType.Union: return new FImplicitObjectUnion();
                case EImplicitObjectType.UnionClustered: return new FImplicitObjectUnionClustered();
                case EImplicitObjectType.LevelSet: return new FLevelSet();
                case EImplicitObjectType.Convex: return new FConvex();
                case EImplicitObjectType.TaperedCylinder: return new FTaperedCylinder();
                case EImplicitObjectType.TaperedCapsule: return new FTaperedCapsule();
                case EImplicitObjectType.TriangleMesh: return new FTriangleMeshImplicitObject();
                case EImplicitObjectType.DEPRECATED_Scaled: return !transfer.Supports.ScaledGeometryIsConcrete ? new TImplicitObjectScaled<FImplicitObject>() : (ITransferible)null;
                case EImplicitObjectType.HeightField: return new FHeightField();
                case EImplicitObjectType.Cylinder: return new FCylinder();
            }

            return null;
        }
    }
}

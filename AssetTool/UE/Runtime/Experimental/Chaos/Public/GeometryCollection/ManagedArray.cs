using AssetTool.Chaos;

namespace AssetTool
{
    public class FManagedArrayBase : ITransferible
    {
        public EManagedArrayType ArrayType;
        public int Version;

        #region Normal Arrays
        public List<FVector3f> Vector;
        public List<FIntVector> IntVector;
        public List<FVector2f> Vector2D;
        public List<FLinearColor> LinearColor;
        public int32[] Int32;
        public List<TUInt8> Bool;
        public List<FTransform> Transform;
        public List<FString> String;
        public float[] Float;
        public List<FQuat4f> Quat;
        ///public List<FGeometryCollectionBoneNode> BoneNode;
        public List<FGeometryCollectionSection> MeshSection;
        public List<FBox> Box;
        public List<TList<TInt32>> IntArray;
        public List<FGuid> Guid;
        public uint8[] UInt8;
        public UInt32[] VectorArrayPointer;
        public List<TList<FVector3f>> VectorArrayUniquePointer;
        public UInt32[] FImplicitObject3Pointer;
        ///public List<Chaos::FImplicitObject3> FImplicitObject3UniquePointer;
        ///public List<Chaos::TSerializablePtr<Chaos::FImplicitObject3>> FImplicitObject3SerializablePtr;
        ///public List<Chaos::FBVHParticlesFloat3> FBVHParticlesFloat3Pointer;
        public List<UniquePtr<FBVHParticles>> FBVHParticlesFloat3UniquePointer;
        public UInt32[] TPBDRigidParticleHandle3fPtr;
        public UInt32[] TPBDGeometryCollectionParticleHandle3fPtr;
        ///public List<Chaos.FGeometryParticle> TGeometryParticle3fUniquePtr;
        ///public List<Chaos.ThreadSafeSharedPtr_FImplicitObject> FImplicitObject3ThreadSafeSharedPointer;
        ///public List<Chaos.NotThreadSafeSharedPtr_FImplicitObject> FImplicitObject3SharedPointer;
        public UInt32[] TPBDRigidClusteredParticleHandle3fPtr;
        ///public List<Chaos.FConvex> FConvexUniquePtr;
        public List<TList<FVector2f>> Vector2DArray;
        public double[] Double;
        public List<FIntVector4> IntVector4;
        public List<FVector3d> Vector3d;
        public List<FIntVector2> IntVector2;
        public List<TList<FIntVector2>> IntVector2Array;
        public List<TList<TInt32>> Int32Array;
        public List<TList<TFloat>> FloatArray;
        public List<FVector4f> Vector4f;
        public List<TList<FVector3f>> FVectorArray;
        ///public List<Chaos.FPBDRigidParticle> TPBDRigidParticle3fUniquePtr;
        public List<TRefCountPtr<FImplicitObject>> FImplicitObjectRefCountedPtr;
        public List<TRefCountPtr<FConvex>> FConvexRefCountedPtr;
        public List<FTransform3f> Transform3f;
        public List<TList<FIntVector3>> IntVector3Array;
        public List<TList<FVector4f>> Vector4fArray;
        ///public List<Chaos.PMatrix33d> PMatrix33d;
        ///public List<List<Chaos.PMatrix33d>> PMatrix33dArray;
        public List<TList<TList<FVector3f>>> FVector3fNestedArray;
        #endregion

        #region Bulk Arrays
        public TBulkList<FVector3f> BulkVector;
        public TBulkList<FIntVector> BulkIntVector;
        public TBulkList<FVector2f> BulkVector2D;
        public TBulkList<FLinearColor> BulkLinearColor;
        public TBulkList<TInt32> BulkInt32;
        public TBulkList<TUInt8> BulkBool;
        public TBulkList<FTransform> BulkTransform;
        public TBulkList<FString> BulkString;
        public TBulkList<TFloat> BulkFloat;
        public TBulkList<FQuat4f> BulkQuat;
        ///public TBulkList<FGeometryCollectionBoneNode> BulkBoneNode;
        public TBulkList<FGeometryCollectionSection> BulkMeshSection;
        public TBulkList<FBox> BulkBox;
        public TBulkList<TList<TInt32>> BulkIntArray;
        public TBulkList<FGuid> BulkGuid;
        public TBulkList<TUInt8> BulkUInt8;
        public TBulkList<TUInt32> BulkVectorArrayPointer;
        public TBulkList<TList<FVector3f>> BulkVectorArrayUniquePointer;
        public TBulkList<TUInt32> BulkFImplicitObject3Pointer;
        ///public TBulkList<Chaos::FImplicitObject3> BulkFImplicitObject3UniquePointer;
        ///public TBulkList<Chaos::TSerializablePtr<Chaos::FImplicitObject3>> BulkFImplicitObject3SerializablePtr;
        ///public TBulkList<Chaos::FBVHParticlesFloat3> BulkFBVHParticlesFloat3Pointer;
        ///public TBulkList<TUniquePtr<Chaos::FBVHParticlesFloat3>> BulkFBVHParticlesFloat3UniquePointer;
        public TBulkList<TUInt32> BulkTPBDRigidParticleHandle3fPtr;
        public TBulkList<TUInt32> BulkTPBDGeometryCollectionParticleHandle3fPtr;
        ///public TBulkList<Chaos.FGeometryParticle> BulkTGeometryParticle3fUniquePtr;
        ///public TBulkList<Chaos.ThreadSafeSharedPtr_FImplicitObject> BulkFImplicitObject3ThreadSafeSharedPointer;
        ///public TBulkList<Chaos.NotThreadSafeSharedPtr_FImplicitObject> BulkFImplicitObject3SharedPointer;
        public TBulkList<TUInt32> BulkTPBDRigidClusteredParticleHandle3fPtr;
        ///public TBulkList<Chaos.FConvex> BulkFConvexUniquePtr;
        public TBulkList<TList<FVector2f>> BulkVector2DArray;
        public TBulkList<TDouble> BulkDouble;
        public TBulkList<FIntVector4> BulkIntVector4;
        public TBulkList<FVector3d> BulkVector3d;
        public TBulkList<FIntVector2> BulkIntVector2;
        public TBulkList<TList<FIntVector2>> BulkIntVector2Array;
        public TBulkList<TList<TInt32>> BulkInt32Array;
        public TBulkList<TList<TFloat>> BulkFloatArray;
        public TBulkList<FVector4f> BulkVector4f;
        public TBulkList<TList<FVector3f>> BulkFVectorArray;
        ///public TBulkList<Chaos.FPBDRigidParticle> BulkTPBDRigidParticle3fUniquePtr;
        public TBulkList<TRefCountPtr<FImplicitObject>> BulkFImplicitObjectRefCountedPtr; //using FImplicitObjectPtr = TRefCountPtr<FImplicitObject>;
        public TBulkList<TRefCountPtr<FConvex>> BulkFConvexRefCountedPtr;
        public TBulkList<FTransform3f> BulkTransform3f;
        public TBulkList<TList<FIntVector3>> BulkIntVector3Array;
        public TBulkList<TList<FVector4f>> BulkVector4fArray;
        ///public TBulkList<Chaos.PMatrix33d> BulkPMatrix33d;
        ///public TBulkList<List<Chaos.PMatrix33d>> BulkPMatrix33dArray;
        public TBulkList<TList<TList<FVector3f>>> BulkFVector3fNestedArray;
        #endregion

        public FManagedArrayBase() { }

        public FManagedArrayBase(EManagedArrayType arrayType)
        {
            ArrayType = arrayType;
        }

        [Location("virtual void Serialize(Chaos::FChaosArchive& Ar) line 574")]
        public virtual ITransferible Move(Transfer transfer)
        {
            ///transfer.AutoCheck<FManagedArrayBase>(ArrayType.ToString(), this, () =>
            ///{
            transfer.Move(ref Version);
            if (!transfer.Supports.BulkSerializeArrays)
            {
                SerializeArray(transfer);
            }
            else
            {
                SerializeBulkArray(transfer);
            }
            ///});
            return this;
        }

        private void SerializeArray(Transfer transfer)
        {
            switch (ArrayType)
            {
                case EManagedArrayType.Vector: transfer.Move(ref Vector); break;
                case EManagedArrayType.IntVector: transfer.Move(ref IntVector); break;
                case EManagedArrayType.Vector2D: transfer.Move(ref Vector2D); break;
                case EManagedArrayType.LinearColor: transfer.Move(ref LinearColor); break;
                case EManagedArrayType.Int32: transfer.Move(ref Int32); break;
                case EManagedArrayType.Bool: transfer.Move(ref Bool); break;
                case EManagedArrayType.Transform: transfer.Move(ref Transform); break;
                case EManagedArrayType.String: transfer.Move(ref String); break;
                case EManagedArrayType.Float: transfer.Move(ref Float); break;
                case EManagedArrayType.Quat: transfer.Move(ref Quat); break;
                //case EManagedArrayType.BoneNode: transfer.Move(ref BoneNode); break;
                case EManagedArrayType.MeshSection: transfer.Move(ref MeshSection); break;
                case EManagedArrayType.Box: transfer.Move(ref Box); break;
                case EManagedArrayType.IntArray: transfer.Move(ref IntArray); break;
                case EManagedArrayType.Guid: transfer.Move(ref Guid); break;
                case EManagedArrayType.UInt8: transfer.Move(ref UInt8); break;
                case EManagedArrayType.VectorArrayPointer: transfer.Move(ref VectorArrayPointer); break;
                case EManagedArrayType.VectorArrayUniquePointer: transfer.Move(ref VectorArrayUniquePointer); break;
                case EManagedArrayType.FImplicitObject3Pointer: transfer.Move(ref FImplicitObject3Pointer); break;
                //case EManagedArrayType.FImplicitObject3UniquePointer: transfer.Move(ref FImplicitObject3UniquePointer); break;
                //case EManagedArrayType.FImplicitObject3SerializablePtr: transfer.Move(ref FImplicitObject3SerializablePtr); break;
                //case EManagedArrayType.FBVHParticlesFloat3Pointer: transfer.Move(ref FBVHParticlesFloat3Pointer); break;
                case EManagedArrayType.FBVHParticlesFloat3UniquePointer: transfer.Move(ref FBVHParticlesFloat3UniquePointer); break;
                case EManagedArrayType.TPBDRigidParticleHandle3fPtr: transfer.Move(ref TPBDRigidParticleHandle3fPtr); break;
                case EManagedArrayType.TPBDGeometryCollectionParticleHandle3fPtr: transfer.Move(ref TPBDGeometryCollectionParticleHandle3fPtr); break;
                //case EManagedArrayType.TGeometryParticle3fUniquePtr: transfer.Move(ref TGeometryParticle3fUniquePtr); break;
                //case EManagedArrayType.FImplicitObject3ThreadSafeSharedPointer: transfer.Move(ref FImplicitObject3ThreadSafeSharedPointer); break;
                //case EManagedArrayType.FImplicitObject3SharedPointer: transfer.Move(ref FImplicitObject3SharedPointer); break;
                case EManagedArrayType.TPBDRigidClusteredParticleHandle3fPtr: transfer.Move(ref TPBDRigidClusteredParticleHandle3fPtr); break;
                //case EManagedArrayType.FConvexUniquePtr: transfer.Move(ref FConvexUniquePtr); break;
                case EManagedArrayType.Vector2DArray: transfer.Move(ref Vector2DArray); break;
                case EManagedArrayType.Double: transfer.Move(ref Double); break;
                case EManagedArrayType.IntVector4: transfer.Move(ref IntVector4); break;
                case EManagedArrayType.Vector3d: transfer.Move(ref Vector3d); break;
                case EManagedArrayType.IntVector2: transfer.Move(ref IntVector2); break;
                case EManagedArrayType.IntVector2Array: transfer.Move(ref IntVector2Array); break;
                case EManagedArrayType.Int32Array: transfer.Move(ref Int32Array); break;
                case EManagedArrayType.FloatArray: transfer.Move(ref FloatArray); break;
                case EManagedArrayType.Vector4f: transfer.Move(ref Vector4f); break;
                case EManagedArrayType.FVectorArray: transfer.Move(ref FVectorArray); break;
                //case EManagedArrayType.TPBDRigidParticle3fUniquePtr: transfer.Move(ref TPBDRigidParticle3fUniquePtr); break;
                case EManagedArrayType.FImplicitObjectRefCountedPtr: transfer.Move(ref FImplicitObjectRefCountedPtr); break;
                case EManagedArrayType.FConvexRefCountedPtr: transfer.Move(ref FConvexRefCountedPtr); break;
                case EManagedArrayType.Transform3f: transfer.Move(ref Transform3f); break;
                case EManagedArrayType.IntVector3Array: transfer.Move(ref IntVector3Array); break;
                case EManagedArrayType.Vector4fArray: transfer.Move(ref Vector4fArray); break;
                //case EManagedArrayType.PMatrix33d: transfer.Move(ref PMatrix33d); break;
                //case EManagedArrayType.PMatrix33dArray: transfer.Move(ref PMatrix33dArray); break;
                case EManagedArrayType.Vector3fNestedArray: transfer.Move(ref FVector3fNestedArray); break;
                default: throw new NotImplementedException();
            }
        }

        private void SerializeBulkArray(Transfer transfer)
        {
            switch (ArrayType)
            {
                case EManagedArrayType.Vector: transfer.Move(ref BulkVector); break; //Should be Bulk here
                case EManagedArrayType.IntVector: transfer.Move(ref BulkIntVector); break;
                case EManagedArrayType.Vector2D: transfer.Move(ref BulkVector2D); break; //Should be Bulk here
                case EManagedArrayType.LinearColor: transfer.Move(ref LinearColor); break;
                case EManagedArrayType.Int32: transfer.Move(ref BulkInt32); break; //Should be Bulk here
                case EManagedArrayType.Bool: transfer.Move(ref BulkBool); break;
                case EManagedArrayType.Transform: transfer.Move(ref Transform); break;
                case EManagedArrayType.String: transfer.Move(ref String); break;
                case EManagedArrayType.Float: transfer.Move(ref BulkFloat); break;
                case EManagedArrayType.Quat: transfer.Move(ref Quat); break;
                //case EManagedArrayType.BoneNode: transfer.Move(ref BoneNode); break;
                case EManagedArrayType.MeshSection: transfer.Move(ref MeshSection); break;
                case EManagedArrayType.Box: transfer.Move(ref Box); break;
                case EManagedArrayType.IntArray: transfer.Move(ref IntArray); break;
                case EManagedArrayType.Guid: transfer.Move(ref Guid); break;
                case EManagedArrayType.UInt8: transfer.Move(ref BulkUInt8); break;
                case EManagedArrayType.VectorArrayPointer: transfer.Move(ref VectorArrayPointer); break;
                case EManagedArrayType.VectorArrayUniquePointer: transfer.Move(ref VectorArrayUniquePointer); break;
                case EManagedArrayType.FImplicitObject3Pointer: transfer.Move(ref FImplicitObject3Pointer); break;
                //case EManagedArrayType.FImplicitObject3UniquePointer: transfer.Move(ref FImplicitObject3UniquePointer); break;
                //case EManagedArrayType.FImplicitObject3SerializablePtr: transfer.Move(ref FImplicitObject3SerializablePtr); break;
                //case EManagedArrayType.FBVHParticlesFloat3Pointer: transfer.Move(ref FBVHParticlesFloat3Pointer); break;
                case EManagedArrayType.FBVHParticlesFloat3UniquePointer: transfer.Move(ref FBVHParticlesFloat3UniquePointer); break;
                case EManagedArrayType.TPBDRigidParticleHandle3fPtr: transfer.Move(ref TPBDRigidParticleHandle3fPtr); break;
                case EManagedArrayType.TPBDGeometryCollectionParticleHandle3fPtr: transfer.Move(ref TPBDGeometryCollectionParticleHandle3fPtr); break;
                //case EManagedArrayType.TGeometryParticle3fUniquePtr: transfer.Move(ref TGeometryParticle3fUniquePtr); break;
                //case EManagedArrayType.FImplicitObject3ThreadSafeSharedPointer: transfer.Move(ref FImplicitObject3ThreadSafeSharedPointer); break;
                //case EManagedArrayType.FImplicitObject3SharedPointer: transfer.Move(ref FImplicitObject3SharedPointer); break;
                case EManagedArrayType.TPBDRigidClusteredParticleHandle3fPtr: transfer.Move(ref TPBDRigidClusteredParticleHandle3fPtr); break;
                //case EManagedArrayType.FConvexUniquePtr: transfer.Move(ref FConvexUniquePtr); break;
                case EManagedArrayType.Vector2DArray: transfer.Move(ref Vector2DArray); break;
                case EManagedArrayType.Double: transfer.Move(ref Double); break;
                case EManagedArrayType.IntVector4: transfer.Move(ref IntVector4); break;
                case EManagedArrayType.Vector3d: transfer.Move(ref Vector3d); break;
                case EManagedArrayType.IntVector2: transfer.Move(ref IntVector2); break;
                case EManagedArrayType.IntVector2Array: transfer.Move(ref IntVector2Array); break;
                case EManagedArrayType.Int32Array: transfer.Move(ref Int32Array); break;
                case EManagedArrayType.FloatArray: transfer.Move(ref FloatArray); break;
                case EManagedArrayType.Vector4f: transfer.Move(ref Vector4f); break;
                case EManagedArrayType.FVectorArray: transfer.Move(ref FVectorArray); break;
                //case EManagedArrayType.TPBDRigidParticle3fUniquePtr: transfer.Move(ref TPBDRigidParticle3fUniquePtr); break;
                case EManagedArrayType.FImplicitObjectRefCountedPtr: transfer.Move(ref FImplicitObjectRefCountedPtr); break;
                case EManagedArrayType.FConvexRefCountedPtr: transfer.Move(ref FConvexRefCountedPtr); break;
                case EManagedArrayType.Transform3f: transfer.Move(ref Transform3f); break;
                case EManagedArrayType.IntVector3Array: transfer.Move(ref IntVector3Array); break;
                case EManagedArrayType.Vector4fArray: transfer.Move(ref Vector4fArray); break;
                //case EManagedArrayType.PMatrix33d: transfer.Move(ref PMatrix33d); break;
                //case EManagedArrayType.PMatrix33dArray: transfer.Move(ref PMatrix33dArray); break;
                case EManagedArrayType.Vector3fNestedArray: transfer.Move(ref FVector3fNestedArray); break;
                default: throw new NotImplementedException();
            }
        }
    }
}
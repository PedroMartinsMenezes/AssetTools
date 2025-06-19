using System.Text.Json.Serialization;

namespace AssetTool.Chaos
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(TBox3), "TBox3")]
    [JsonDerivedType(typeof(FCapsule), "FCapsule")]
    [JsonDerivedType(typeof(FConvex), "FConvex")]
    [JsonDerivedType(typeof(FCylinder), "FCylinder")]
    [JsonDerivedType(typeof(FHeightField), "FHeightField")]
    [JsonDerivedType(typeof(FImplicitObjectScaled), "FImplicitObjectScaled")]
    [JsonDerivedType(typeof(TImplicitObjectScaled<FConvex>), "TImplicitObjectScaledFConvex")]
    [JsonDerivedType(typeof(TImplicitObjectScaled<FTriangleMeshImplicitObject>), "TImplicitObjectScaledFTriangleMeshImplicitObject")]
    [JsonDerivedType(typeof(TImplicitObjectScaled<FImplicitObject>), "TImplicitObjectScaledFImplicitObject")]
    [JsonDerivedType(typeof(FImplicitObjectInstanced), "FImplicitObjectInstanced")]
    [JsonDerivedType(typeof(TImplicitObjectInstanced<FConvex>), "TImplicitObjectInstancedFConvex")]
    [JsonDerivedType(typeof(TImplicitObjectInstanced<FTriangleMeshImplicitObject>), "TImplicitObjectInstancedFTriangleMeshImplicitObject")]
    [JsonDerivedType(typeof(TImplicitObjectTransformed3<TDouble>), "TImplicitObjectTransformed3TDouble")]
    [JsonDerivedType(typeof(FLevelSet), "FLevelSet")]
    [JsonDerivedType(typeof(TPlane3), "TPlane3")]
    [JsonDerivedType(typeof(TSphere3), "TSphere3")]
    [JsonDerivedType(typeof(FTaperedCapsule), "FTaperedCapsule")]
    [JsonDerivedType(typeof(FTaperedCylinder), "FTaperedCylinder")]
    [JsonDerivedType(typeof(FTriangleMeshImplicitObject), "FTriangleMeshImplicitObject")]
    [JsonDerivedType(typeof(FImplicitObjectUnion), "FImplicitObjectUnion")]
    public class FImplicitObject : ITransferible
    {
        public FBool bIsConvex;
        public FBool bDoCollide;
        public Chaos.EImplicitObjectType CollisionType;

        [Location("void FImplicitObject::SerializeImp(FArchive& Ar)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.ChaosArchiveAdded)
            {
                transfer.Move(ref bIsConvex);
                transfer.Move(ref bDoCollide);
            }
            if (transfer.SupportsAfter.CustomImplicitCollisionType)
            {
                CollisionType = (Chaos.EImplicitObjectType)transfer.Move((byte)CollisionType);
            }
            return this;

        }
    }
}

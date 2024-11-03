namespace AssetTool
{
    public class FRawSkeletalMeshBulkData : ITransferible
    {
        public FBool bGuidIsHash;
        public FGuid Guid;
        public FByteBulkData BulkData;
        public ESkeletalMeshGeoImportVersions GeoImportVersion;
        public ESkeletalMeshSkinningImportVersions SkinningImportVersion;

        public ITransferible Move(Transfer transfer)
        {
            if (Supports.SkeletalMeshBuildRefactor)
            {
                GeoImportVersion = (ESkeletalMeshGeoImportVersions)transfer.Move((byte)GeoImportVersion);
                SkinningImportVersion = (ESkeletalMeshSkinningImportVersions)transfer.Move((byte)SkinningImportVersion);
            }
            transfer.Move(ref BulkData);
            transfer.Move(ref Guid);
            transfer.Move(ref bGuidIsHash);
            return this;
        }
    }

    public enum ESkeletalMeshGeoImportVersions : byte
    {
        Before_Versionning = 0,
        SkeletalMeshBuildRefactor,
        VersionPlusOne,
        LatestVersion = VersionPlusOne - 1
    }

    public enum ESkeletalMeshSkinningImportVersions : byte
    {
        Before_Versionning = 0,
        SkeletalMeshBuildRefactor,
        VersionPlusOne,
        LatestVersion = VersionPlusOne - 1
    }

    public struct FVertInfluence : ITransferible
    {
        public float Weight;
        public UInt32 VertIndex;
        public FBoneIndexType BoneIndex;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Weight);
            transfer.Move(ref VertIndex);
            transfer.Move(ref BoneIndex);
            return this;
        }
    }
}

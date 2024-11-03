namespace AssetTool
{
    public class FReferenceSkeleton : ITransferible
    {
        public List<FMeshBoneInfo> RawRefBoneInfo;
        public List<FTransform> RawRefBonePose;
        public Dictionary<FName, TInt32> RawNameToIndexMap;

        [Location("FArchive & operator<<(FArchive & Ar, FReferenceSkeleton & F)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref RawRefBoneInfo);
            transfer.Move(ref RawRefBonePose);

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_REFERENCE_SKELETON_REFACTOR))
            {
                transfer.Move(ref RawNameToIndexMap);
            }

            return this;
        }
    }

    public class FMeshBoneInfo : ITransferible
    {
        public FName Name;
        public Int32 ParentIndex;
        public FColor DummyColor;
        public FString ExportName;

        [Location("FArchive &operator<<(FArchive& Ar, FMeshBoneInfo& F)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref ParentIndex);
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_REFERENCE_SKELETON_REFACTOR))
            {
                transfer.Move(ref DummyColor);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_STORE_BONE_EXPORT_NAMES))
            {
                transfer.Move(ref ExportName);
            }
            return this;
        }
    }
}

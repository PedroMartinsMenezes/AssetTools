namespace AssetTool
{
    public class FReferenceSkeleton : ITransferible
    {
        public List<FMeshBoneInfo> RawRefBoneInfo = [];
        public List<FTransform3d> RawRefBonePose = [];
        public Dictionary<FName, TInt32> RawNameToIndexMap;

        public ITransferible Move(Transfer transfer)
        {
            RawRefBoneInfo.Resize(transfer);
            RawRefBoneInfo.ForEach(x => x.Move(transfer));

            RawRefBonePose.Resize(transfer);
            RawRefBonePose.ForEach(x => x.Move(transfer));

            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_REFERENCE_SKELETON_REFACTOR))
            {
                RawNameToIndexMap ??= new();
                RawNameToIndexMap.Move(transfer, key => transfer.Move(key), value => value.Move(transfer));
            }

            return this;
        }
    }

    public class FMeshBoneInfo
    {
        public FName Name;
        public Int32 ParentIndex;
        public FColor DummyColor;
        public FString ExportName;

        [Location("FArchive &operator<<(FArchive& Ar, FMeshBoneInfo& F)")]
        public void Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref ParentIndex);
            if (!Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_REFERENCE_SKELETON_REFACTOR))
            {
                DummyColor ??= new();
                DummyColor.Move(transfer);
            }
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_STORE_BONE_EXPORT_NAMES))
            {
                transfer.Move(ref ExportName);
            }
        }
    }
}

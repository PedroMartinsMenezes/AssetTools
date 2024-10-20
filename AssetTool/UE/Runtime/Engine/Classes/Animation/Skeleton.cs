namespace AssetTool
{
    [JsonAsset("Skeleton")]
    public class USkeleton : UObject
    {
        public FReferenceSkeleton ReferenceSkeleton;
        public Dictionary<FName, FReferencePose> AnimRetargetSources;
        public FGuid FGuid;
        public FSmartNameContainer SmartNames_DEPRECATED;
        public FStripDataFlags StripFlags;
        public List<FName> ExistingMarkerNames;

        [Location("void USkeleton::Serialize( FArchive& Ar )")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.VER_UE4_REFERENCE_SKELETON_REFACTOR)
            {
                transfer.Move(ref ReferenceSkeleton);
            }
            ///if (Supports.VER_UE4_FIX_ANIMATIONBASEPOSE_SERIALIZATION)
            transfer.Move(ref AnimRetargetSources);
            if (Supports.VER_UE4_SKELETON_GUID_SERIALIZATION)
            {
                transfer.Move(ref FGuid);
            }
            if (Supports.VER_UE4_SKELETON_ADD_SMARTNAMES)
            {
                transfer.Move(ref SmartNames_DEPRECATED);
            }
            if (Supports.StoreMarkerNamesOnSkeleton)
            {
                transfer.Move(ref StripFlags);
                if (!StripFlags.IsEditorDataStripped())
                {
                    transfer.Move(ref ExistingMarkerNames);
                }
            }
            return this;
        }
    }

    public class FReferencePose : ITransferible
    {
        public FName PoseName;
        public List<FTransform> ReferencePose;
        public UInt32 SourceReferenceMesh;

        [Location("void SerializeReferencePose(FArchive& Ar, FReferencePose& P, UObject* Outer)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref PoseName);
            transfer.Move(ref ReferencePose);
            transfer.Move(ref SourceReferenceMesh);
            return this;
        }
    }
}
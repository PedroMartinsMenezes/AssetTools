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
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.VER_UE4_REFERENCE_SKELETON_REFACTOR)
            {
                transfer.Move(ref ReferenceSkeleton);
            }
            if (transfer.Supports.VER_UE4_FIX_ANIMATIONBASEPOSE_SERIALIZATION)
            {
                transfer.Move(ref AnimRetargetSources);
            }
            if (transfer.Supports.VER_UE4_SKELETON_GUID_SERIALIZATION)
            {
                transfer.Move(ref FGuid);
            }
            if (transfer.Supports.VER_UE4_SKELETON_ADD_SMARTNAMES)
            {
                transfer.Move(ref SmartNames_DEPRECATED);
            }
            if (transfer.Supports.StoreMarkerNamesOnSkeleton)
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

    public class FReferencePose : ITransferable
    {
        public FName PoseName;
        public List<FTransform> ReferencePose;
        public FSoftObjectPtr SourceReferenceMesh;

        [Location("void SerializeReferencePose(FArchive& Ar, FReferencePose& P, UObject* Outer)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref PoseName);
            transfer.Move(ref ReferencePose);
            if (!transfer.Supports.ChangeRetargetSourceReferenceToSoftObjectPtr)
            {
                transfer.Move(ref SourceReferenceMesh, (x) => x.MovePtr(transfer));
            }
            else
            {
                transfer.Move(ref SourceReferenceMesh);
            }
            return this;
        }
    }
}
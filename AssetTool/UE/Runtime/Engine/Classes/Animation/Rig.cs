namespace AssetTool
{
    [JsonAsset("Rig")]
    public class URig : UObject
    {
        public FReferenceSkeleton SourceSkeleton;

        [Location("void URig::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            if (transfer.Supports.AddSourceReferenceSkeletonToRig)
            {
                transfer.Move(ref SourceSkeleton);

            }
            return this;
        }
    }
}
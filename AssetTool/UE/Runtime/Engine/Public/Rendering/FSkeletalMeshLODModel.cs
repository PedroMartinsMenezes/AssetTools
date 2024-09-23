namespace AssetTool
{
    public class FSkeletalMeshLODModel : ITransferible<FSkeletalMeshLODModel>
    {
        public FStripDataFlags StripFlags = new();

        [Location("void FSkeletalMeshLODModel::Serialize(FArchive& Ar, UObject* Owner, int32 Idx)")]
        public override void Move(Transfer transfer)
        {
            StripFlags.Move(transfer);
            if (StripFlags.IsDataStrippedForServer())
            {
                //TODO lot of work
            }
        }
    }
}

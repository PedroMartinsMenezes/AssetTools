namespace AssetTool
{
    public class FSkeletalMeshLODModel : Transferible<FSkeletalMeshLODModel>
    {
        public FStripDataFlags StripFlags = new();

        [Location("void FSkeletalMeshLODModel::Serialize(FArchive& Ar, UObject* Owner, int32 Idx)")]
        public override ITransferible Move(Transfer transfer)
        {
            StripFlags.Move(transfer);
            if (StripFlags.IsDataStrippedForServer())
            {
                //TODO lot of work
            }
            return this;
        }
    }
}

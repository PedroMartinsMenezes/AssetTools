namespace AssetTool
{
    [JsonAsset("ParentFilter")]
    public class UParentFilter : ULevelSnapshotFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
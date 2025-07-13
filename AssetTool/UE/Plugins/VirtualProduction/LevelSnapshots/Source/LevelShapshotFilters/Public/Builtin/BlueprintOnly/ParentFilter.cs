namespace AssetTool
{
    [JsonAsset("ParentFilter")]
    public class UParentFilter : ULevelSnapshotFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ConstantFilter")]
    public class UConstantFilter : ULevelSnapshotFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
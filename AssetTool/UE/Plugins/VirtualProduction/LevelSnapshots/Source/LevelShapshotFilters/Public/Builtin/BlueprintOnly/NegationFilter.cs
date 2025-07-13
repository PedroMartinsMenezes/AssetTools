namespace AssetTool
{
    [JsonAsset("NegationFilter")]
    public class UNegationFilter : ULevelSnapshotFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
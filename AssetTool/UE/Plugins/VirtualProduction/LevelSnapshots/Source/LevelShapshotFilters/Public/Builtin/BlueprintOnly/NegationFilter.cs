namespace AssetTool
{
    [JsonAsset("NegationFilter")]
    public class UNegationFilter : ULevelSnapshotFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("EmptySourceFilter")]
    public class UEmptySourceFilter : UDataSourceFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
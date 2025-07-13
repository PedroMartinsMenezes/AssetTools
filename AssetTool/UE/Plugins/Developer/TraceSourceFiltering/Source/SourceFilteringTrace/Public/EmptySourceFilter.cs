namespace AssetTool
{
    [JsonAsset("EmptySourceFilter")]
    public class UEmptySourceFilter : UDataSourceFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
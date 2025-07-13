namespace AssetTool
{
    [JsonAsset("DataSourceFilterSet")]
    public class UDataSourceFilterSet : UDataSourceFilter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
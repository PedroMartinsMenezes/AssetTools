namespace AssetTool
{
    [JsonAsset("DataSourceFilterSet")]
    public class UDataSourceFilterSet : UDataSourceFilter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
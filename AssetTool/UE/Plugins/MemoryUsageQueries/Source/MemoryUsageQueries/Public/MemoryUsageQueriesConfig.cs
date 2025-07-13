namespace AssetTool
{
    [JsonAsset("MemoryUsageQueriesConfig")]
    public class UMemoryUsageQueriesConfig : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
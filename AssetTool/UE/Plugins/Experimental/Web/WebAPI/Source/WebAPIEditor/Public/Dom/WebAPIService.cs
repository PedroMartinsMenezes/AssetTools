namespace AssetTool
{
    [JsonAsset("WebAPIService")]
    public class UWebAPIService : UWebAPIModelBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
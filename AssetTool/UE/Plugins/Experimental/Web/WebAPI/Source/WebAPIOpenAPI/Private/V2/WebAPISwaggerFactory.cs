namespace AssetTool
{
    [JsonAsset("WebAPISwaggerAssetData")]
    public class UWebAPISwaggerAssetData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPISwaggerFactory")]
    public class UWebAPISwaggerFactory : UWebAPIOpenAPIFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
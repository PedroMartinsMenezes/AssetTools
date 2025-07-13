namespace AssetTool
{
    [JsonAsset("WebAPIOpenAPIAssetData")]
    public class UWebAPIOpenAPIAssetData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPIOpenAPIFactory")]
    public class UWebAPIOpenAPIFactory : UWebAPIOpenAPIFactoryBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
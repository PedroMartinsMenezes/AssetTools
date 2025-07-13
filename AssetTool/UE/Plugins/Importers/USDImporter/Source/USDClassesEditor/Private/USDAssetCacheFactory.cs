namespace AssetTool
{
    [JsonAsset("UsdAssetCacheFactory")]
    public class UUsdAssetCacheFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
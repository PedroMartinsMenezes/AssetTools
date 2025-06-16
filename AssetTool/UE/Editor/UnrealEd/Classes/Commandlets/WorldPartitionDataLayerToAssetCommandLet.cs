namespace AssetTool
{
    [JsonAsset("DataLayerConversionInfo")]
    public class UDataLayerConversionInfo : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataLayerToAssetCommandletContext")]
    public class UDataLayerToAssetCommandletContext : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataLayerToAssetCommandlet")]
    public class UDataLayerToAssetCommandlet : UCommandlet
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
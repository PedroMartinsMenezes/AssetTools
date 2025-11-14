namespace AssetTool
{
    [JsonAsset("DataLayerConversionInfo")]
    public class UDataLayerConversionInfo : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataLayerToAssetCommandletContext")]
    public class UDataLayerToAssetCommandletContext : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("DataLayerToAssetCommandlet")]
    public class UDataLayerToAssetCommandlet : UCommandlet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
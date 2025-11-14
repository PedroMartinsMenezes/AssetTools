namespace AssetTool
{
    [JsonAsset("PCGLoadDataAssetSettings")]
    public class UPCGLoadDataAssetSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
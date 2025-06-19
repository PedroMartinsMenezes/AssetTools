namespace AssetTool
{
    [JsonAsset("PCGLoadDataAssetSettings")]
    public class UPCGLoadDataAssetSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
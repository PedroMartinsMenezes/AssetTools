namespace AssetTool
{
    [JsonAsset("PCGLoadDataAssetSettings")]
    public class UPCGLoadDataAssetSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
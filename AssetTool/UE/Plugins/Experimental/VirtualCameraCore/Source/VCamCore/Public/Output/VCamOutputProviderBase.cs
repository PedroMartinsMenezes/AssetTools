namespace AssetTool
{
    [JsonAsset("VCamOutputProviderBase")]
    public class UVCamOutputProviderBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
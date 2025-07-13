namespace AssetTool
{
    [JsonAsset("VCamOutputProviderBase")]
    public class UVCamOutputProviderBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
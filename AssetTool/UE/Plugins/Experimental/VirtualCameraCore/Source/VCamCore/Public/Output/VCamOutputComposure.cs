namespace AssetTool
{
    [JsonAsset("VCamOutputComposure")]
    public class UVCamOutputComposure : UVCamOutputProviderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
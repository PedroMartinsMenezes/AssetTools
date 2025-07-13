namespace AssetTool
{
    [JsonAsset("VCamOutputMediaOutput")]
    public class UVCamOutputMediaOutput : UVCamOutputProviderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
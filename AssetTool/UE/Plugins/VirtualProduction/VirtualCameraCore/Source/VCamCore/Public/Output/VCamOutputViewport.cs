namespace AssetTool
{
    [JsonAsset("VCamOutputViewport")]
    public class UVCamOutputViewport : UVCamOutputProviderBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
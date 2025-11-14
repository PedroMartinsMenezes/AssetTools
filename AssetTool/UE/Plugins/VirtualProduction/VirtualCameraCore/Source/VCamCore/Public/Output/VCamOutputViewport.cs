namespace AssetTool
{
    [JsonAsset("VCamOutputViewport")]
    public class UVCamOutputViewport : UVCamOutputProviderBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("VCamOutputMediaOutput")]
    public class UVCamOutputMediaOutput : UVCamOutputProviderBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("VCamPixelStreamingSession")]
    public class UVCamPixelStreamingSession : UDecoupledOutputProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
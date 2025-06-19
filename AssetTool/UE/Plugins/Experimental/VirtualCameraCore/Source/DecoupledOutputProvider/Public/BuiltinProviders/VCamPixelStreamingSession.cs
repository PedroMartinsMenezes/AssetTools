namespace AssetTool
{
    [JsonAsset("VCamPixelStreamingSession")]
    public class UVCamPixelStreamingSession : UDecoupledOutputProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
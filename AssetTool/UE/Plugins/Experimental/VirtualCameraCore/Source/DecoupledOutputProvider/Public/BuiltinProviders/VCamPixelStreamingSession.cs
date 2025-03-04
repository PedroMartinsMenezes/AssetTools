namespace AssetTool
{
    [JsonAsset("VCamPixelStreamingSession")]
    public class UVCamPixelStreamingSession : UDecoupledOutputProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
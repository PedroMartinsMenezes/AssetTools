namespace AssetTool
{
    [JsonAsset("CaptureTimecodeInfo")]
    public class UCaptureTimecodeInfo : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("CaptureTimecodeInfo")]
    public class UCaptureTimecodeInfo : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
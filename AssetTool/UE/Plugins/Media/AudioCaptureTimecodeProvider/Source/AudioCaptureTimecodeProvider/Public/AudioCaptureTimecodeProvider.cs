namespace AssetTool
{
    [JsonAsset("AudioCaptureTimecodeProvider")]
    public class UAudioCaptureTimecodeProvider : UGenlockedTimecodeProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
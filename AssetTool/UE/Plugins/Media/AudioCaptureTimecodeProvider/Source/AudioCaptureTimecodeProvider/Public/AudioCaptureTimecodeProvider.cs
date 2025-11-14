namespace AssetTool
{
    [JsonAsset("AudioCaptureTimecodeProvider")]
    public class UAudioCaptureTimecodeProvider : UGenlockedTimecodeProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
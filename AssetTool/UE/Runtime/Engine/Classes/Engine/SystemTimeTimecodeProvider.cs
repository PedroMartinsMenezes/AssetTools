namespace AssetTool
{
    [JsonAsset("SystemTimeTimecodeProvider")]
    public class USystemTimeTimecodeProvider : UTimecodeProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
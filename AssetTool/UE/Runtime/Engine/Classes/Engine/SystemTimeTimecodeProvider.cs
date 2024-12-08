namespace AssetTool
{
    [JsonAsset("SystemTimeTimecodeProvider")]
    public class USystemTimeTimecodeProvider : UTimecodeProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
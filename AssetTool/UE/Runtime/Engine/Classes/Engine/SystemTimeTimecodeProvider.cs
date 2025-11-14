namespace AssetTool
{
    [JsonAsset("SystemTimeTimecodeProvider")]
    public class USystemTimeTimecodeProvider : UTimecodeProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
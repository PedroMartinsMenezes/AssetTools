namespace AssetTool
{
    [JsonAsset("GenlockedTimecodeProvider")]
    public class UGenlockedTimecodeProvider : UTimecodeProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("RivermaxTimecodeProvider")]
    public class URivermaxTimecodeProvider : UGenlockedTimecodeProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
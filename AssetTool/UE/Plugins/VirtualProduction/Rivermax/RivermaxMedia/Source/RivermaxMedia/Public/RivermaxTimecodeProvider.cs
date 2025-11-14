namespace AssetTool
{
    [JsonAsset("RivermaxTimecodeProvider")]
    public class URivermaxTimecodeProvider : UGenlockedTimecodeProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
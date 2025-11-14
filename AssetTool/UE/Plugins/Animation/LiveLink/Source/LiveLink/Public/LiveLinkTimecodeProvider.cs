namespace AssetTool
{
    [JsonAsset("LiveLinkTimecodeProvider")]
    public class ULiveLinkTimecodeProvider : UTimecodeProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
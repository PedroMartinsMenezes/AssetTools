namespace AssetTool
{
    [JsonAsset("LiveLinkTimecodeProvider")]
    public class ULiveLinkTimecodeProvider : UTimecodeProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
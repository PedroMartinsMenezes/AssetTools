namespace AssetTool
{
    [JsonAsset("SocialReadOnlyChatChannel")]
    public class USocialReadOnlyChatChannel : USocialChatChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
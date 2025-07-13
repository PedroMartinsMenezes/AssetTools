namespace AssetTool
{
    [JsonAsset("SocialReadOnlyChatChannel")]
    public class USocialReadOnlyChatChannel : USocialChatChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
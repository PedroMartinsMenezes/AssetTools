namespace AssetTool
{
    [JsonAsset("SocialPrivateMessageChannel")]
    public class USocialPrivateMessageChannel : USocialChatChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
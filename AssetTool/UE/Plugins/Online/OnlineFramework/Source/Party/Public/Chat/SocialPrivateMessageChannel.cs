namespace AssetTool
{
    [JsonAsset("SocialPrivateMessageChannel")]
    public class USocialPrivateMessageChannel : USocialChatChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
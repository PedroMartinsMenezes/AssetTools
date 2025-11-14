namespace AssetTool
{
    [JsonAsset("SocialChatRoom")]
    public class USocialChatRoom : USocialChatChannel
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
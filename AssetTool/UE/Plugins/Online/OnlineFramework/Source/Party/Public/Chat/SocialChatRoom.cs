namespace AssetTool
{
    [JsonAsset("SocialChatRoom")]
    public class USocialChatRoom : USocialChatChannel
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("SocialPartyChatRoom")]
    public class USocialPartyChatRoom : USocialChatRoom
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
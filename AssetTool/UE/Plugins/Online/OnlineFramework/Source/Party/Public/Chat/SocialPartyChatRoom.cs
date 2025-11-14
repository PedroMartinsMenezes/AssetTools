namespace AssetTool
{
    [JsonAsset("SocialPartyChatRoom")]
    public class USocialPartyChatRoom : USocialChatRoom
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ConversationSettings")]
    public class UConversationSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
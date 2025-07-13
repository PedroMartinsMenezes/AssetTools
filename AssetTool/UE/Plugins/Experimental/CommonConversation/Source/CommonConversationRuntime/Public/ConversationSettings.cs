namespace AssetTool
{
    [JsonAsset("ConversationSettings")]
    public class UConversationSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ConversationRegistry")]
    public class UConversationRegistry : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
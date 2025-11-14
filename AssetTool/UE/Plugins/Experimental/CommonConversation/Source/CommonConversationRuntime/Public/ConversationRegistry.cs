namespace AssetTool
{
    [JsonAsset("ConversationRegistry")]
    public class UConversationRegistry : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
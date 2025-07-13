namespace AssetTool
{
    [JsonAsset("ConversationInstance")]
    public class UConversationInstance : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
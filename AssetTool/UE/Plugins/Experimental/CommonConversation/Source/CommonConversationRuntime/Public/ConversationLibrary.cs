namespace AssetTool
{
    [JsonAsset("ConversationLibrary")]
    public class UConversationLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
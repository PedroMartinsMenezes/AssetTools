namespace AssetTool
{
    [JsonAsset("ConversationContextHelpers")]
    public class UConversationContextHelpers : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
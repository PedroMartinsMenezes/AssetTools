namespace AssetTool
{
    [JsonAsset("ConversationLibrary")]
    public class UConversationLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
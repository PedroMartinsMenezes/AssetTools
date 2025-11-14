namespace AssetTool
{
    [JsonAsset("AssistProcessor")]
    public class UAssistProcessor : UGameplayMessageProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("WidgetGraphSchema")]
    public class UWidgetGraphSchema : UEdGraphSchema_K2
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
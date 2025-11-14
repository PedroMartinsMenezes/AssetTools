namespace AssetTool
{
    [JsonAsset("DataprepGraphSchema")]
    public class UDataprepGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
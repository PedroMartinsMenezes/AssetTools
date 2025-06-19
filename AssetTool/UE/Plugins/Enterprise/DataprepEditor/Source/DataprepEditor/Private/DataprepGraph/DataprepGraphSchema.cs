namespace AssetTool
{
    [JsonAsset("DataprepGraphSchema")]
    public class UDataprepGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
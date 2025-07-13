namespace AssetTool
{
    [JsonAsset("DataflowSchema")]
    public class UDataflowSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
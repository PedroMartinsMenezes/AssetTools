namespace AssetTool
{
    [JsonAsset("DataflowSchema")]
    public class UDataflowSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("AIGraphSchema")]
    public class UAIGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
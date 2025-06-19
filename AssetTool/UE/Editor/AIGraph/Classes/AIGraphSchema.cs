namespace AssetTool
{
    [JsonAsset("AIGraphSchema")]
    public class UAIGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
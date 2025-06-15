namespace AssetTool
{
    [JsonAsset("AIGraphSchema")]
    public class UAIGraphSchema : UEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
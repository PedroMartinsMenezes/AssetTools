namespace AssetTool
{
    [JsonAsset("EdGraphSchema")]
    public class UEdGraphSchema : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
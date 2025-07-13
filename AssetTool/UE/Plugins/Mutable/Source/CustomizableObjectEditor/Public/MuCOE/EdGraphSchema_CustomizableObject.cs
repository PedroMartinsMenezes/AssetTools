namespace AssetTool
{
    [JsonAsset("EdGraphSchema_CustomizableObject")]
    public class UEdGraphSchema_CustomizableObject : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
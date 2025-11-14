namespace AssetTool
{
    [JsonAsset("EdGraphSchema_CustomizableObject")]
    public class UEdGraphSchema_CustomizableObject : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
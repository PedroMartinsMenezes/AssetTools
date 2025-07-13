namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeObject")]
    public class UCustomizableObjectNodeObject : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeMaterialBase")]
    public class UCustomizableObjectNodeMaterialBase : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeComponent")]
    public class UCustomizableObjectNodeComponent : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeModifierBase")]
    public class UCustomizableObjectNodeModifierBase : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
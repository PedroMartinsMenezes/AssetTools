namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeModifierBase")]
    public class UCustomizableObjectNodeModifierBase : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeSwitchBase")]
    public class UCustomizableObjectNodeSwitchBase : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
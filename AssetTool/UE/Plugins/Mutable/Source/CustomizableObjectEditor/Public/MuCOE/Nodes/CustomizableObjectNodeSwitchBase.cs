namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeSwitchBase")]
    public class UCustomizableObjectNodeSwitchBase : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
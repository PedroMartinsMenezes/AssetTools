namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodePassThroughTextureSwitch")]
    public class UCustomizableObjectNodePassThroughTextureSwitch : UCustomizableObjectNodeSwitchBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
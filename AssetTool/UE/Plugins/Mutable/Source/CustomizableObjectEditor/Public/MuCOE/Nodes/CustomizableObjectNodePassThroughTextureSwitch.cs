namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodePassThroughTextureSwitch")]
    public class UCustomizableObjectNodePassThroughTextureSwitch : UCustomizableObjectNodeSwitchBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
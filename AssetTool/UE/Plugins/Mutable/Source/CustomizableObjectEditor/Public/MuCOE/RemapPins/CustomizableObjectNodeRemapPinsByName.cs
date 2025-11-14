namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeRemapPinsByName")]
    public class UCustomizableObjectNodeRemapPinsByName : UCustomizableObjectNodeRemapPins
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
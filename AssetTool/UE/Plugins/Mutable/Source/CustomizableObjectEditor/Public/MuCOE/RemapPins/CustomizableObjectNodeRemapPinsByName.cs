namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeRemapPinsByName")]
    public class UCustomizableObjectNodeRemapPinsByName : UCustomizableObjectNodeRemapPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
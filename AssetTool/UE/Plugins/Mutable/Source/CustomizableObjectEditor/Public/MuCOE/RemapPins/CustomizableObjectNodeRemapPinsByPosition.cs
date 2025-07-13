namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeRemapPinsByPosition")]
    public class UCustomizableObjectNodeRemapPinsByPosition : UCustomizableObjectNodeRemapPins
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
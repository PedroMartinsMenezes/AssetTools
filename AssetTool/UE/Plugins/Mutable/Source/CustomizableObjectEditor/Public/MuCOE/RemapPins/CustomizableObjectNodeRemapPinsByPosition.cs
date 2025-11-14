namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeRemapPinsByPosition")]
    public class UCustomizableObjectNodeRemapPinsByPosition : UCustomizableObjectNodeRemapPins
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
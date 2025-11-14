namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeRemapPinsByNameDefaultPin")]
    public class UCustomizableObjectNodeRemapPinsByNameDefaultPin : UCustomizableObjectNodeRemapPinsByName
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
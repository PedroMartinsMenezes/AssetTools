namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeRemapPinsByNameDefaultPin")]
    public class UCustomizableObjectNodeRemapPinsByNameDefaultPin : UCustomizableObjectNodeRemapPinsByName
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
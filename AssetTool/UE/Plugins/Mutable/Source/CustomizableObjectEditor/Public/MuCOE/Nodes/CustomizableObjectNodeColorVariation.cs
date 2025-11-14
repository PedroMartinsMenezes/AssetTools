namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeColorVariation")]
    public class UCustomizableObjectNodeColorVariation : UCustomizableObjectNodeVariation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
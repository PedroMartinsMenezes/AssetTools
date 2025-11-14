namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeVariation")]
    public class UCustomizableObjectNodeVariation : UCustomizableObjectNode
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
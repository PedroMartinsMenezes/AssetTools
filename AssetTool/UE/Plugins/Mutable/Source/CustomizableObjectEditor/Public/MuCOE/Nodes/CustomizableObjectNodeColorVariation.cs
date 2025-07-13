namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeColorVariation")]
    public class UCustomizableObjectNodeColorVariation : UCustomizableObjectNodeVariation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
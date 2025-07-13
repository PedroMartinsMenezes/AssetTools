namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeVariation")]
    public class UCustomizableObjectNodeVariation : UCustomizableObjectNode
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
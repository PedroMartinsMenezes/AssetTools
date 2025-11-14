namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeComponentVariation")]
    public class UCustomizableObjectNodeComponentVariation : UCustomizableObjectNodeVariation
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
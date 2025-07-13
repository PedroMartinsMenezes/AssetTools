namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeComponentVariation")]
    public class UCustomizableObjectNodeComponentVariation : UCustomizableObjectNodeVariation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
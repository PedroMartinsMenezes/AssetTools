namespace AssetTool
{
    [JsonAsset("CustomizableObjectNodeFloatVariation")]
    public class UCustomizableObjectNodeFloatVariation : UCustomizableObjectNodeVariation
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
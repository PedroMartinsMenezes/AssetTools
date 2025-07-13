namespace AssetTool
{
    [JsonAsset("CustomizableObjectPopulation")]
    public class UCustomizableObjectPopulation : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
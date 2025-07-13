namespace AssetTool
{
    [JsonAsset("CustomizableObjectPopulationGenerator")]
    public class UCustomizableObjectPopulationGenerator : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
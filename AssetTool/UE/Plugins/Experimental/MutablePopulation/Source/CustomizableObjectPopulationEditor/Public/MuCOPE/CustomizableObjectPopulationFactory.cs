namespace AssetTool
{
    [JsonAsset("CustomizableObjectPopulationFactory")]
    public class UCustomizableObjectPopulationFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
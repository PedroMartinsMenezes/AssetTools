namespace AssetTool
{
    [JsonAsset("CustomizableObjectPopulationFactory")]
    public class UCustomizableObjectPopulationFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
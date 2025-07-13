namespace AssetTool
{
    [JsonAsset("CustomizableObjectPopulationClassFactory")]
    public class UCustomizableObjectPopulationClassFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
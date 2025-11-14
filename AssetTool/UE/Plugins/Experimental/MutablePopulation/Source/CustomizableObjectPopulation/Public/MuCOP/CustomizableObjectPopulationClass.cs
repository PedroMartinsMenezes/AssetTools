namespace AssetTool
{
    [JsonAsset("CustomizableObjectPopulationClass")]
    public class UCustomizableObjectPopulationClass : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
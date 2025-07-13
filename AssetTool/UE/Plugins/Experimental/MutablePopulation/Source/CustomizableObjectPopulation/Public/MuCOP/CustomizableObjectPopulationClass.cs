namespace AssetTool
{
    [JsonAsset("CustomizableObjectPopulationClass")]
    public class UCustomizableObjectPopulationClass : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
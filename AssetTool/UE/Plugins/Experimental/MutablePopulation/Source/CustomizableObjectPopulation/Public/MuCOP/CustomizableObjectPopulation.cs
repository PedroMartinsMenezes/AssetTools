namespace AssetTool
{
    [JsonAsset("CustomizableObjectPopulation")]
    public class UCustomizableObjectPopulation : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
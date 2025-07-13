namespace AssetTool
{
    [JsonAsset("AssetDefinition_CustomizableObjectPopulation")]
    public class UAssetDefinition_CustomizableObjectPopulation : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
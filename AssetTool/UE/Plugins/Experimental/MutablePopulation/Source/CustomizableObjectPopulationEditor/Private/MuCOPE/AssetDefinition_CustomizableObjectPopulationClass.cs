namespace AssetTool
{
    [JsonAsset("AssetDefinition_CustomizableObjectPopulationClass")]
    public class UAssetDefinition_CustomizableObjectPopulationClass : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
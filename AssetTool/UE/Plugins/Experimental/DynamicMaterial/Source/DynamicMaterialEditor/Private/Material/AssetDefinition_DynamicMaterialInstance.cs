namespace AssetTool
{
    [JsonAsset("AssetDefinition_DynamicMaterialInstance")]
    public class UAssetDefinition_DynamicMaterialInstance : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
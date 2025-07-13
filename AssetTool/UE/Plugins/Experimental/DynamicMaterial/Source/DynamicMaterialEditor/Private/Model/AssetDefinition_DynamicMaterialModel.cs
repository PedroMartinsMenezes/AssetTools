namespace AssetTool
{
    [JsonAsset("AssetDefinition_DynamicMaterialModel")]
    public class UAssetDefinition_DynamicMaterialModel : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
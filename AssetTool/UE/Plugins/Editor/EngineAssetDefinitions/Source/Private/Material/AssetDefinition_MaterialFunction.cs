namespace AssetTool
{
    [JsonAsset("AssetDefinition_MaterialFunction")]
    public class UAssetDefinition_MaterialFunction : UAssetDefinitionDefault
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetDefinition_MaterialFunctionMaterialLayer")]
    public class UAssetDefinition_MaterialFunctionMaterialLayer : UAssetDefinition_MaterialFunction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetDefinition_MaterialFunctionLayerBlend")]
    public class UAssetDefinition_MaterialFunctionLayerBlend : UAssetDefinition_MaterialFunction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
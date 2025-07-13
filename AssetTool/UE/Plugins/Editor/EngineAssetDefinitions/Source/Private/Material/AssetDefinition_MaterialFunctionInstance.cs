namespace AssetTool
{
    [JsonAsset("AssetDefinition_MaterialFunctionInstance")]
    public class UAssetDefinition_MaterialFunctionInstance : UAssetDefinition_MaterialFunction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetDefinition_MaterialFunctionLayerInstance")]
    public class UAssetDefinition_MaterialFunctionLayerInstance : UAssetDefinition_MaterialFunctionInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetDefinition_MaterialFunctionLayerBlendInstance")]
    public class UAssetDefinition_MaterialFunctionLayerBlendInstance : UAssetDefinition_MaterialFunctionInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
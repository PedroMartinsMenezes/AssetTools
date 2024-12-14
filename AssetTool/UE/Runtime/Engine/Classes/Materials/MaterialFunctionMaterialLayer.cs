namespace AssetTool
{
    [JsonAsset("MaterialFunctionMaterialLayer")]
    public class UMaterialFunctionMaterialLayer : UMaterialFunction
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunctionMaterialLayerInstance")]
    public class UMaterialFunctionMaterialLayerInstance : UMaterialFunctionInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
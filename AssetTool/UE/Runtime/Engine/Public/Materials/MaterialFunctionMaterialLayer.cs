namespace AssetTool
{
    [JsonAsset("MaterialFunctionMaterialLayer")]
    public class UMaterialFunctionMaterialLayer : UMaterialFunction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunctionMaterialLayerInstance")]
    public class UMaterialFunctionMaterialLayerInstance : UMaterialFunctionInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
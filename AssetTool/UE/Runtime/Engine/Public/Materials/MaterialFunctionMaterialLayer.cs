namespace AssetTool
{
    [JsonAsset("MaterialFunctionMaterialLayer")]
    public class UMaterialFunctionMaterialLayer : UMaterialFunction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunctionMaterialLayerInstance")]
    public class UMaterialFunctionMaterialLayerInstance : UMaterialFunctionInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
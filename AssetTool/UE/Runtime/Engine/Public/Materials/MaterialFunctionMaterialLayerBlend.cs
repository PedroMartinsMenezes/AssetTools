namespace AssetTool
{
    [JsonAsset("MaterialFunctionMaterialLayerBlend")]
    public class UMaterialFunctionMaterialLayerBlend : UMaterialFunction
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunctionMaterialLayerBlendInstance")]
    public class UMaterialFunctionMaterialLayerBlendInstance : UMaterialFunctionInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
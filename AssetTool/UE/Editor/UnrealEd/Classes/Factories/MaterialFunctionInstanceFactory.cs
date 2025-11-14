namespace AssetTool
{
    [JsonAsset("MaterialFunctionInstanceFactory")]
    public class UMaterialFunctionInstanceFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunctionMaterialLayerInstanceFactory")]
    public class UMaterialFunctionMaterialLayerInstanceFactory : UMaterialFunctionInstanceFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialFunctionMaterialLayerBlendInstanceFactory")]
    public class UMaterialFunctionMaterialLayerBlendInstanceFactory : UMaterialFunctionInstanceFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
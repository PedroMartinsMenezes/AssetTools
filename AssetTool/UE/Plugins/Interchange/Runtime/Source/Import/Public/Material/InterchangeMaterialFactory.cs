namespace AssetTool
{
    [JsonAsset("InterchangeMaterialFactory")]
    public class UInterchangeMaterialFactory : UInterchangeFactoryBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("InterchangeMaterialFunctionFactory")]
    public class UInterchangeMaterialFunctionFactory : UInterchangeFactoryBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
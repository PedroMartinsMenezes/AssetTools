namespace AssetTool
{
    [JsonAsset("MaterialExpressionFloatToUInt")]
    public class UMaterialExpressionFloatToUInt : UMaterialExpression
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionUIntToFloat")]
    public class UMaterialExpressionUIntToFloat : UMaterialExpression
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
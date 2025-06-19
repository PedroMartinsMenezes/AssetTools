namespace AssetTool
{
    [JsonAsset("MaterialExpressionFloatToUInt")]
    public class UMaterialExpressionFloatToUInt : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionUIntToFloat")]
    public class UMaterialExpressionUIntToFloat : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
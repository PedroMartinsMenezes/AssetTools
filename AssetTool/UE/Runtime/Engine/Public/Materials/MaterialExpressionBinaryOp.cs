namespace AssetTool
{
    [JsonAsset("MaterialExpressionBinaryOp")]
    public class UMaterialExpressionBinaryOp : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionLess")]
    public class UMaterialExpressionLess : UMaterialExpressionBinaryOp
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
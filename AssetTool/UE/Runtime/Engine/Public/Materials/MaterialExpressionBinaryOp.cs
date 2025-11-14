namespace AssetTool
{
    [JsonAsset("MaterialExpressionBinaryOp")]
    public class UMaterialExpressionBinaryOp : UMaterialExpression
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionLess")]
    public class UMaterialExpressionLess : UMaterialExpressionBinaryOp
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
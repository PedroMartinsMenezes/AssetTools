namespace AssetTool
{
    [JsonAsset("MaterialExpressionGenericConstant")]
    public class UMaterialExpressionGenericConstant : UMaterialExpression
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionConstantDouble")]
    public class UMaterialExpressionConstantDouble : UMaterialExpressionGenericConstant
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
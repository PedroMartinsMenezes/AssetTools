namespace AssetTool
{
    [JsonAsset("MaterialExpressionLocalPosition")]
    public class UMaterialExpressionLocalPosition : UMaterialExpression
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
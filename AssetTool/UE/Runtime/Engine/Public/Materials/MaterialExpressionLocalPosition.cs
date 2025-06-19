namespace AssetTool
{
    [JsonAsset("MaterialExpressionLocalPosition")]
    public class UMaterialExpressionLocalPosition : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
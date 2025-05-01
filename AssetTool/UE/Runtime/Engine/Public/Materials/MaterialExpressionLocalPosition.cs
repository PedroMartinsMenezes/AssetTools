namespace AssetTool
{
    [JsonAsset("MaterialExpressionLocalPosition")]
    public class UMaterialExpressionLocalPosition : UMaterialExpression
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("MaterialExpressionTransformPosition")]
    public class UMaterialExpressionTransformPosition : UMaterialExpression
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
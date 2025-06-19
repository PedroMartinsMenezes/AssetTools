namespace AssetTool
{
    [JsonAsset("MaterialExpressionTransformPosition")]
    public class UMaterialExpressionTransformPosition : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
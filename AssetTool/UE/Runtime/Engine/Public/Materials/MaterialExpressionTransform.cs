namespace AssetTool
{
    [JsonAsset("MaterialExpressionTransform")]
    public class UMaterialExpressionTransform : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
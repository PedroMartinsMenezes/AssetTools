namespace AssetTool
{
    [JsonAsset("MaterialExpressionPinBase")]
    public class UMaterialExpressionPinBase : UMaterialExpression
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
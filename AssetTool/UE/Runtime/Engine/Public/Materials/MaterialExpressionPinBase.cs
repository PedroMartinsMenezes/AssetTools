namespace AssetTool
{
    [JsonAsset("MaterialExpressionPinBase")]
    public class UMaterialExpressionPinBase : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
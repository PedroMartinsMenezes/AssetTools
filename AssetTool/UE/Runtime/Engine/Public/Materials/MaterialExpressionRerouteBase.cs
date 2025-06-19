namespace AssetTool
{
    [JsonAsset("MaterialExpressionRerouteBase")]
    public class UMaterialExpressionRerouteBase : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
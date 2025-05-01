namespace AssetTool
{
    [JsonAsset("MaterialExpressionRerouteBase")]
    public class UMaterialExpressionRerouteBase : UMaterialExpression
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
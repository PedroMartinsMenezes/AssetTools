namespace AssetTool
{
    [JsonAsset("MaterialExpressionRerouteBase")]
    public class UMaterialExpressionRerouteBase : UMaterialExpression
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
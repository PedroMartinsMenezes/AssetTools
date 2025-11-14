namespace AssetTool
{
    [JsonAsset("MaterialExpressionWorldPosition")]
    public class UMaterialExpressionWorldPosition : UMaterialExpression
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
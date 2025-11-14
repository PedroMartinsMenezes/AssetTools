namespace AssetTool
{
    [JsonAsset("MaterialExpressionBlendMaterialAttributes")]
    public class UMaterialExpressionBlendMaterialAttributes : UMaterialExpression
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionLegacyBlendMaterialAttributes")]
    public class UMaterialExpressionLegacyBlendMaterialAttributes : UMaterialExpressionBlendMaterialAttributes
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
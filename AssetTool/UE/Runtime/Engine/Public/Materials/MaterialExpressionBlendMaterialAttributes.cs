namespace AssetTool
{
    [JsonAsset("MaterialExpressionBlendMaterialAttributes")]
    public class UMaterialExpressionBlendMaterialAttributes : UMaterialExpression
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MaterialExpressionLegacyBlendMaterialAttributes")]
    public class UMaterialExpressionLegacyBlendMaterialAttributes : UMaterialExpressionBlendMaterialAttributes
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
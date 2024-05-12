namespace AssetTool
{
    [Location("void UMaterialExpression::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMaterialExpressionLinearInterpolate : UMaterialExpression
    {
        public const string TypeName = "MaterialExpressionLinearInterpolate";

        public new UMaterialExpressionLinearInterpolate Move(Transfer transfer) => (UMaterialExpressionLinearInterpolate)base.Move(transfer);
    }
}

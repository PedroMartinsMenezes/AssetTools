namespace AssetTool
{
    [Location("void UMaterialExpression::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMaterialExpressionLinearInterpolate : UMaterialExpression
    {
        public const string TypeName = "MaterialExpressionLinearInterpolate";

        public new UMaterialExpressionLinearInterpolate Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}

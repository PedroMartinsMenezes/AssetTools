namespace AssetTool
{
    [Location("void UMaterialExpression::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMaterialExpressionLinearInterpolate : UMaterialExpression
    {
        public const string TypeName = "MaterialExpressionLinearInterpolate";
    }

    public static class UMaterialExpressionLinearInterpolateExt
    {
        public static void Write(this BinaryWriter writer, UMaterialExpressionLinearInterpolate item)
        {
            writer.Write((UMaterialExpression)item);
        }

        public static UMaterialExpressionLinearInterpolate Read(this BinaryReader reader, UMaterialExpressionLinearInterpolate item)
        {
            reader.Read((UMaterialExpression)item);
            return item;
        }
    }
}

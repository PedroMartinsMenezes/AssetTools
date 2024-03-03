namespace AssetTool
{
    [Location("void UMaterialExpression::Serialize(FStructuredArchive::FRecord Record)")]
    public class UMaterialExpression : UObject
    {
    }

    public static class UMaterialExpressionExt
    {
        public static void Write(this BinaryWriter writer, UMaterialExpression item)
        {
            writer.Write((UObject)item);
        }

        public static UMaterialExpression Read(this BinaryReader reader, UMaterialExpression item)
        {
            reader.Read((UObject)item);
            //9304
            return item;
        }
    }
}

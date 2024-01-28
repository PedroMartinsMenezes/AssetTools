namespace AssetTool.Model
{
    public class UK2Node_DynamicCast : UK2Node
    {
    }

    public static class UK2Node_DynamicCastExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_DynamicCast item)
        {
            writer.Write((UK2Node)item);
        }

        public static UK2Node_DynamicCast Read(this BinaryReader reader, UK2Node_DynamicCast item)
        {
            reader.Read((UK2Node)item);
            return item;
        }
    }
}

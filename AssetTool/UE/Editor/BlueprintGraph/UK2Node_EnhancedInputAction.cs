namespace AssetTool
{
    public class UK2Node_EnhancedInputAction : UK2Node
    {
    }

    public static class UK2Node_EnhancedInputActionExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_EnhancedInputAction item)
        {
            writer.Write((UK2Node)item);
        }

        public static UK2Node_EnhancedInputAction Read(this BinaryReader reader, UK2Node_EnhancedInputAction item)
        {
            reader.Read((UK2Node)item);
            return item;
        }
    }
}

namespace AssetTool
{
    public class UK2Node_CallFunction : UK2Node
    {
    }

    public static class UK2Node_CallFunctionExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_CallFunction item)
        {
            writer.Write((UK2Node)item);
        }

        public static UK2Node_CallFunction Read(this BinaryReader reader, UK2Node_CallFunction item)
        {
            reader.Read((UK2Node)item);
            return item;
        }
    }
}

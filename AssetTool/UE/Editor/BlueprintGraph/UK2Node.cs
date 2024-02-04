namespace AssetTool
{
    public class UK2Node : UEdGraphNode
    {
    }

    public static class UK2NodeExt
    {
        public static void Write(this BinaryWriter writer, UK2Node item)
        {
            writer.Write((UEdGraphNode)item);
        }

        public static UK2Node Read(this BinaryReader reader, UK2Node item)
        {
            reader.Read((UEdGraphNode)item);
            return item;
        }
    }
}

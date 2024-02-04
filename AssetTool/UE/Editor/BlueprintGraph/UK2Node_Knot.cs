namespace AssetTool
{
    public class UK2Node_Knot : UK2Node
    {
    }

    public static class UK2Node_KnotExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_Knot item)
        {
            writer.Write((UK2Node)item);
        }

        public static UK2Node_Knot Read(this BinaryReader reader, UK2Node_Knot item)
        {
            reader.Read((UK2Node)item);
            return item;
        }
    }
}

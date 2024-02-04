namespace AssetTool
{
    public class UK2Node_EditablePinBase : UK2Node
    {
    }

    public static class UK2Node_EditablePinBaseExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_EditablePinBase item)
        {
            writer.Write((UK2Node)item);
        }

        public static UK2Node_EditablePinBase Read(this BinaryReader reader, UK2Node_EditablePinBase item)
        {
            reader.Read((UK2Node)item);
            return item;
        }
    }
}

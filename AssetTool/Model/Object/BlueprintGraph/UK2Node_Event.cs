namespace AssetTool.Model
{
    public class UK2Node_Event : UK2Node_EditablePinBase
    {
    }

    public static class UK2Node_EventExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_Event item)
        {
            writer.Write((UK2Node)item);
        }

        public static UK2Node_Event Read(this BinaryReader reader, UK2Node_Event item)
        {
            reader.Read((UK2Node)item);
            return item;
        }
    }
}

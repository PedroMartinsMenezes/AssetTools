namespace AssetTool
{
    [Location("void UK2Node_Event::Serialize(FArchive& Ar)")]
    public class UK2Node_Event : UK2Node_EditablePinBase
    {
        public const string TypeName = "K2Node_Event";
    }

    public static class UK2Node_EventExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_Event item)
        {
            writer.Write((UK2Node_EditablePinBase)item);
        }

        public static UK2Node_Event Read(this BinaryReader reader, UK2Node_Event item)
        {
            reader.Read((UK2Node_EditablePinBase)item);
            return item;
        }
    }
}

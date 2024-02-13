namespace AssetTool
{
    [Location("void UK2Node_FunctionEntry::Serialize(FArchive& Ar)")]
    public class UK2Node_FunctionEntry : UK2Node_FunctionTerminator
    {
        public const string TypeName = "K2Node_FunctionEntry";
    }

    public static class UK2Node_FunctionEntryExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_FunctionEntry item)
        {
            writer.Write((UK2Node_FunctionTerminator)item);
        }

        public static UK2Node_FunctionEntry Read(this BinaryReader reader, UK2Node_FunctionEntry item)
        {
            reader.Read((UK2Node_FunctionTerminator)item);
            return item;
        }
    }
}

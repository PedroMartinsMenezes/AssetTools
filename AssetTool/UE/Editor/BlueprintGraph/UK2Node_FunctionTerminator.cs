namespace AssetTool
{
    [Location("void UK2Node_EditablePinBase::Serialize(FArchive& Ar)")]
    public class UK2Node_FunctionTerminator : UK2Node_EditablePinBase
    {
    }

    public static class UK2Node_FunctionTerminatorExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_FunctionTerminator item)
        {
            writer.Write((UK2Node_EditablePinBase)item);
        }

        public static UK2Node_FunctionTerminator Read(this BinaryReader reader, UK2Node_FunctionTerminator item)
        {
            reader.Read((UK2Node_EditablePinBase)item);
            return item;
        }
    }
}

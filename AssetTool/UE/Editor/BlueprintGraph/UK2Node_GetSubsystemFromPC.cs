namespace AssetTool
{

    public class UK2Node_GetSubsystemFromPC : UK2Node_GetSubsystem
    {
        public const string TypeName = "K2Node_GetSubsystemFromPC";
    }

    public static class UK2Node_GetSubsystemFromPCExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_GetSubsystemFromPC item)
        {
            writer.Write((UK2Node_GetSubsystem)item);
        }

        public static UK2Node_GetSubsystemFromPC Read(this BinaryReader reader, UK2Node_GetSubsystemFromPC item)
        {
            reader.Read((UK2Node_GetSubsystem)item);
            return item;
        }
    }
}

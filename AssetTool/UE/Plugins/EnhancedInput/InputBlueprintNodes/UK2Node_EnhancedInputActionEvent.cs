namespace AssetTool
{
    public class UK2Node_EnhancedInputActionEvent : UK2Node_Event
    {
    }

    public static class UK2Node_EnhancedInputActionEventExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_EnhancedInputActionEvent item)
        {
            writer.Write((UK2Node_Event)item);
        }

        public static void Read(this BinaryReader reader, UK2Node_EnhancedInputActionEvent item)
        {
            reader.Read((UK2Node_Event)item);
        }
    }
}

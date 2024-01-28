namespace AssetTool.Model
{
    public class UK2Node_MacroInstance : UK2Node_Tunnel
    {
    }

    public static class UK2Node_MacroInstanceExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_MacroInstance item)
        {
            writer.Write((UK2Node_Tunnel)item);
        }

        public static UK2Node_MacroInstance Read(this BinaryReader reader, UK2Node_MacroInstance item)
        {
            reader.Read((UK2Node_Tunnel)item);
            return item;
        }
    }
}

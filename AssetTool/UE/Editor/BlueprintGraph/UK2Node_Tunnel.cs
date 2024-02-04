namespace AssetTool
{
    public class UK2Node_Tunnel : UK2Node_EditablePinBase
    {
    }

    public static class UK2Node_TunnelExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_Tunnel item)
        {
            writer.Write((UK2Node_EditablePinBase)item);
        }

        public static UK2Node_Tunnel Read(this BinaryReader reader, UK2Node_Tunnel item)
        {
            reader.Read((UK2Node_EditablePinBase)item);
            return item;
        }
    }
}

namespace AssetTool
{
    [Location("void UK2Node_DynamicCast::Serialize(FArchive& Ar)")]
    public class UK2Node_DynamicCast : UK2Node
    {
        public const string TypeName = "K2Node_DynamicCast";

        public byte PureState;
    }

    public static class UK2Node_DynamicCastExt
    {
        public static void Write(this BinaryWriter writer, UK2Node_DynamicCast item)
        {
            writer.Write((UK2Node)item);
            writer.Write(item.PureState);
        }

        public static UK2Node_DynamicCast Read(this BinaryReader reader, UK2Node_DynamicCast item)
        {
            reader.Read((UK2Node)item);
            reader.Read(ref item.PureState);
            return item;
        }
    }
}

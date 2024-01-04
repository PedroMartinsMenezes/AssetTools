namespace AssetTool
{
    public class FPropertyTag
    {
        public FName Type = new();
        public byte BoolVal;
        public FName StructName = new();
        public FName EnumName = new();
        public FName InnerType = new();
        public FName ValueType = new();
        public Int32 Size;
        public Int32 ArrayIndex;
        public Int64 SizeOffset;
        public FGuid StructGuid;
        public byte HasPropertyGuid;
        public FGuid PropertyGuid;
    }

    public static class FPropertyTagExt
    {
        public static void Write(this BinaryWriter writer, FPropertyTag item)
        {
            writer.Write(item.Type);
        }

        public static FPropertyTag Read(this BinaryReader reader, FPropertyTag item)
        {
            reader.Read(item.Type);
            return item;
        }
    }
}

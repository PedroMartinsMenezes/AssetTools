namespace AssetTool
{
    [Location("UFunction::Serialize( FArchive& Ar )")]
    public class UFunction : UStruct
    {
        public const string TypeName = "Function";

        public UInt32 FunctionFlags;
        public UInt32 EventGraphFunction;
        public Int32 EventGraphCallOffset;
    }

    public static class UFunctionExt
    {
        public static void Write(this BinaryWriter writer, UFunction item)
        {
            writer.Write((UStruct)item);
        }

        public static UFunction Read(this BinaryReader reader, UFunction item)
        {
            reader.Read((UStruct)item); //74402..

            reader.Read(ref item.FunctionFlags);
            reader.Read(ref item.EventGraphFunction);
            reader.Read(ref item.EventGraphCallOffset);

            return item;
        }
    }
}

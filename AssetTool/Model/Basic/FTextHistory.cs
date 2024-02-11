namespace AssetTool
{
    [Location("void FTextHistory_Base::Serialize(FStructuredArchive::FRecord Record)")]
    public class FTextHistory
    {
        public FString Namespace;
        public FString Key;
        public FString SourceString;
    }

    public static class FTextHistoryExt
    {
        public static void Write(this BinaryWriter writer, FTextHistory item)
        {
            writer.Write(item.Namespace);
            writer.Write(item.Key);
            writer.Write(item.SourceString);
        }

        public static FTextHistory Read(this BinaryReader reader, ref FTextHistory item)
        {
            item ??= new();
            reader.Read(ref item.Namespace);
            reader.Read(ref item.Key);
            reader.Read(ref item.SourceString);
            return item;
        }
    }
}

namespace AssetTool
{
    public class FGatherableTextData
    {
        public FString NamespaceName = new();
        public FTextSourceData SourceData = new();
        public List<FTextSourceSiteContext> SourceSiteContexts;
    }

    public static class GatherableTextDataExt
    {
        public static void Write(this BinaryWriter writer, FGatherableTextData item)
        {
            if (item is null) return;
        }

        public static List<FGatherableTextData> ReadList(this BinaryReader reader, int count, FGatherableTextData item)
        {
            return Enumerable.Range(0, count).Select(x => reader.Read(new FGatherableTextData())).ToList();
        }

        public static FGatherableTextData Read(this BinaryReader reader, FGatherableTextData item)
        {
            return item;
        }
    }
}

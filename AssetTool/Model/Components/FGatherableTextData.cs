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
            throw new NotImplementedException();
        }

        public static List<FGatherableTextData> GatherableTextDataList(this BinaryReader reader, int offset, int count)
        {
            reader.BaseStream.Position = offset;
            return Enumerable.Range(0, count).Select(x => reader.Read(new FGatherableTextData())).ToList();
        }

        public static FGatherableTextData Read(this BinaryReader reader, FGatherableTextData item)
        {
            throw new NotImplementedException();
        }
    }
}

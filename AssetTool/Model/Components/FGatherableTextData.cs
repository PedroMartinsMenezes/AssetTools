namespace AssetTool
{
    [Location("void operator<<(FStructuredArchive::FSlot Slot, FGatherableTextData& This)")]
    public class FGatherableTextData
    {
        public FString NamespaceName;
        public FTextSourceData SourceData = new();
        public List<FTextSourceSiteContext> SourceSiteContexts = [];
    }

    public static class FGatherableTextDataExt
    {
        public static List<FGatherableTextData> Read(this BinaryReader reader, List<FGatherableTextData> list, int count)
        {
            list ??= new();
            list.Resize(count);
            list.ForEach(item => reader.Read(item));
            return list;
        }

        public static FGatherableTextData Read(this BinaryReader reader, FGatherableTextData item)
        {
            item ??= new();
            reader.Read(ref item.NamespaceName);
            reader.Read(ref item.SourceData.SourceString);
            reader.Read(ref item.SourceData.SourceStringMetaData);
            item.SourceSiteContexts.Resize(reader.ReadInt32());
            foreach (var context in item.SourceSiteContexts)
            {
                reader.Read(ref context.KeyName);
                reader.Read(ref context.SiteDescription);
                reader.Read(ref context.IsEditorOnly);
                reader.Read(ref context.IsOptional);

                context.InfoMetaData.MapKeys.Resize(reader.ReadInt32());
                for (int i = 0; i < context.InfoMetaData.MapKeys.Count; i++)
                {
                    context.InfoMetaData.MapKeys[i] = reader.ReadFString();
                }

                context.KeyMetaData.MapKeys.Resize(reader.ReadInt32());
                for (int i = 0; i < context.KeyMetaData.MapKeys.Count; i++)
                {
                    context.KeyMetaData.MapKeys[i] = reader.ReadFString();
                }
            }
            return item;
        }

        public static void Write(this BinaryWriter writer, List<FGatherableTextData> list)
        {
            list.ForEach(writer.Write);
        }

        public static void Write(this BinaryWriter writer, FGatherableTextData item)
        {
            writer.Write(item.NamespaceName);
            writer.Write(item.SourceData.SourceString);
            writer.Write(item.SourceData.SourceStringMetaData);
            writer.Write(item.SourceSiteContexts.Count);
            foreach (var context in item.SourceSiteContexts)
            {
                writer.Write(context.KeyName);
                writer.Write(context.SiteDescription);
                writer.Write(context.IsEditorOnly);
                writer.Write(context.IsOptional);

                writer.Write(context.InfoMetaData.MapKeys.Count);
                for (int i = 0; i < context.InfoMetaData.MapKeys.Count; i++)
                {
                    writer.Write(context.InfoMetaData.MapKeys[i]);
                }

                writer.Write(context.KeyMetaData.MapKeys.Count);
                for (int i = 0; i < context.KeyMetaData.MapKeys.Count; i++)
                {
                    writer.Write(context.KeyMetaData.MapKeys[i]);
                }
            }
        }
    }
}

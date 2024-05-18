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
            list.Resize(GlobalObjects.Transfer, count);
            list.ForEach(item => reader.Read(item));
            return list;
        }

        public static FGatherableTextData Read(this BinaryReader reader, FGatherableTextData item)
        {
            var transfer = GlobalObjects.Transfer;
            item ??= new();
            transfer.Move(ref item.NamespaceName);
            transfer.Move(ref item.SourceData.SourceString);
            transfer.Move(ref item.SourceData.SourceStringMetaData);
            item.SourceSiteContexts.Resize(GlobalObjects.Transfer);
            foreach (var context in item.SourceSiteContexts)
            {
                transfer.Move(ref context.KeyName);
                transfer.Move(ref context.SiteDescription);
                transfer.Move(ref context.IsEditorOnly);
                transfer.Move(ref context.IsOptional);

                context.InfoMetaData.MapKeys.Resize(GlobalObjects.Transfer);
                for (int i = 0; i < context.InfoMetaData.MapKeys.Count; i++)
                {
                    context.InfoMetaData.MapKeys[i] = reader.ReadFString();
                }

                context.KeyMetaData.MapKeys.Resize(GlobalObjects.Transfer);
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
            var transfer = GlobalObjects.Transfer;
            transfer.Move(ref item.NamespaceName);
            transfer.Move(ref item.SourceData.SourceString);
            transfer.Move(ref item.SourceData.SourceStringMetaData);
            transfer.Move(item.SourceSiteContexts.Count);
            foreach (var context in item.SourceSiteContexts)
            {
                transfer.Move(ref context.KeyName);
                transfer.Move(ref context.SiteDescription);
                transfer.Move(ref context.IsEditorOnly);
                transfer.Move(ref context.IsOptional);

                transfer.Move(context.InfoMetaData.MapKeys.Count);
                for (int i = 0; i < context.InfoMetaData.MapKeys.Count; i++)
                {
                    transfer.Move(context.InfoMetaData.MapKeys[i]);
                }

                transfer.Move(context.KeyMetaData.MapKeys.Count);
                for (int i = 0; i < context.KeyMetaData.MapKeys.Count; i++)
                {
                    transfer.Move(context.KeyMetaData.MapKeys[i]);
                }
            }
        }
    }
}

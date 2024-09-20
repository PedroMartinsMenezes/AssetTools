namespace AssetTool
{
    [Location("Load the thumbnail table of contents")]
    public class ThumbnailTable
    {
        [Sized]
        public List<ThumbnailEntry> ThumbnailEntries = [];

        public int SizeOf() => 4 + ThumbnailEntries.Sum(x => x.SizeOf());

        public class ThumbnailEntry
        {
            public int SizeOf() => ObjectShortClassName.SizeOf() + ObjectPathWithoutPackageName.SizeOf() + 4;

            public FString ObjectShortClassName = new();
            public FString ObjectPathWithoutPackageName = new();
            public Int32 FileOffset;
        }
    }

    public static class ThumbnailTableExt
    {
        public static void Write(this BinaryWriter writer, ThumbnailTable item)
        {
            if (item is null)
                return;
            writer.Write(item.ThumbnailEntries.Count);
            foreach (ThumbnailTable.ThumbnailEntry entry in item.ThumbnailEntries)
            {
                writer.Write(entry.ObjectShortClassName);
                writer.Write(entry.ObjectPathWithoutPackageName);
                writer.Write(entry.FileOffset);
            }
        }

        public static ThumbnailTable Read(this BinaryReader reader, ThumbnailTable item, long offset)
        {
            if (offset == 0)
                return null;
            item ??= new();
            item.ThumbnailEntries = Enumerable.Range(0, reader.ReadInt32()).Select(x => new ThumbnailTable.ThumbnailEntry()).ToList();
            foreach (ThumbnailTable.ThumbnailEntry entry in item.ThumbnailEntries)
            {
                reader.Read(ref entry.ObjectShortClassName);
                reader.Read(ref entry.ObjectPathWithoutPackageName);
                reader.Read(ref entry.FileOffset);
            }
            return item;
        }
    }
}

namespace AssetTool
{
    [Location("Record << SA_VALUE(TEXT(\"SearchableNamesOffset\"), Sum.SearchableNamesOffset);")]
    public class SearchableNamesMap
    {
        public int SizeOf() => 4 + Map.Count * FPackageIndex.SIZE + Map.Values.Count * 4 + Map.Values.Sum(x => x.Count * 8);

        public Dictionary<string, List<FName>> Map = new();
    }

    public static class SearchableNamesMapExt
    {
        public static void Write(this BinaryWriter writer, SearchableNamesMap item)
        {
            if (item is null)
                return;
            writer.Write(item.Map.Count);
            foreach (var pair in item.Map)
            {
                string key = pair.Key;
                List<FName> list = pair.Value;

                writer.Write(Int32.Parse(key));
                writer.Write(list.Count);
                for (int j = 0; j < list.Count; j++)
                {
                    writer.Write(list[j]);
                }
            }
        }

        public static SearchableNamesMap Read(this BinaryReader reader, SearchableNamesMap item, long offset)
        {
            if (offset == 0)
                return null;
            item ??= new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                FPackageIndex key = new FPackageIndex() { Index = reader.ReadInt32() };
                List<FName> list = new List<FName>();

                int numNames = reader.ReadInt32();
                for (int j = 0; j < numNames; j++)
                {
                    list.Add(reader.ReadFName());
                }

                item.Map.Add(key.Index.ToString(), list);
            }
            return item;
        }
    }
}

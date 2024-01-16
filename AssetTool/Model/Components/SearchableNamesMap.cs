namespace AssetTool
{
    //2620..2624
    public class SearchableNamesMap
    {
        public Dictionary<FPackageIndex, List<FName>> Map = new();
    }

    public static class SearchableNamesMapExt
    {
        public static void Write(this BinaryWriter writer, SearchableNamesMap item)
        {
            if (item is null) return;
            writer.Write(item.Map.Count);
            foreach (var pair in item.Map) 
            { 
                writer.Write(pair.Key.Index);
                writer.Write(pair.Value);
            }
        }

        public static SearchableNamesMap ReadSearchableNamesMap(this BinaryReader reader, int offset)
        {
            SearchableNamesMap item = new();
            int count = reader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                var key = new FPackageIndex { Index = reader.ReadInt32() };
                var list = new List<FName>();
                item.Map.Add(key, list);
                int count2 = reader.ReadInt32();
                for (int j = 0; j < count2; j++)
                {
                    list.Add(reader.Read(new FName()));
                }
            }
            return item;
        }
    }
}

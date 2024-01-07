namespace AssetTool
{
    //2608..2620
    public class DependsMap
    {
        public List<List<FPackageIndex>> Map = new();
    }

    public static class DependsMapExt
    {
        public static void Write(this BinaryWriter writer, DependsMap dependsMap)
        {
            if (dependsMap is null) return;
            foreach (var list in dependsMap.Map)
            {
                writer.Write(list.Count);
                list.ForEach(writer.Write);
            }
        }

        public static DependsMap ReadDependsMap(this BinaryReader reader, int offset, int count)
        {
            reader.BaseStream.Position = offset;

            DependsMap dependsMap = new();
            var list1 = dependsMap.Map;

            for (int i = 0; i < count; i++)
            {
                var list2 = new List<FPackageIndex>();
                list1.Add(list2);

                int count2 = reader.ReadInt32();
                for (int j = 0; j < count2; i++)
                {
                    list2.Add(reader.ReadPackageIndex(new()));
                }
            }

            return dependsMap;
        }
    }
}

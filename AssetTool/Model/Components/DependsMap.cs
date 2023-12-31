namespace AssetTool
{
    //2608..2620
    //TArray<TArray<FPackageIndex> >
    //depends map size is same as export map size
    //C:\src\UnrealEngine\Engine\Source\Runtime\CoreUObject\Private\UObject\LinkerLoad.cpp 2275
    public class DependsMap
    {
        public List<List<FPackageIndex>> Depends = new();
    }

    public static class DependsMapExt
    {
        public static void Write(this BinaryWriter writer, DependsMap dependsMap)
        {
            if (dependsMap is null) return;
            foreach (var list in dependsMap.Depends)
            {
                writer.Write(list.Count);
                list.ForEach(writer.Write);
            }
        }

        public static DependsMap Read(this BinaryReader reader, int count, DependsMap dependsMap)
        {
            for (int i = 0; i < count; i++)
            {
                var list = new List<FPackageIndex>();
                dependsMap.Depends.Add(list);
                int size = reader.ReadInt32();
                list = Enumerable.Range(0, size).Select(x => reader.Read(new FPackageIndex())).ToList();
            }
            return dependsMap;
        }
    }
}

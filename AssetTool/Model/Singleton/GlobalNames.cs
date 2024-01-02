namespace AssetTool
{
    public static class GlobalNames
    {
        static List<string> Names = new();

        public static string Get(uint index)
        {
            return Names[(int)index];
        }

        internal static void Set(List<FNameEntrySerialized> nameMap)
        {
            Names = nameMap.Select(x => x.Name.Value).ToList();
        }
    }
}

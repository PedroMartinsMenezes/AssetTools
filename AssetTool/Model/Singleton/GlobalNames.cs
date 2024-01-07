namespace AssetTool
{
    public static class GlobalNames
    {
        private static List<string> Names { get; set; } = new();

        public static string Get(FNameEntryId x) => Names[(int)x.Value];

        public static string Get(FName x) => Names[(int)x.ComparisonIndex.Value];

        public static string Get(UInt32 x) => Names[(int)x];

        public static FName None { get; set; }

        public static UInt32 NAME_StructProperty { get; set; }
        public static UInt32 NAME_BoolProperty { get; set; }
        public static UInt32 NAME_ByteProperty { get; set; }
        public static UInt32 NAME_EnumProperty { get; set; }
        public static UInt32 NAME_ArrayProperty { get; set; }
        public static UInt32 NAME_OptionalProperty { get; set; }
        public static UInt32 NAME_SetProperty { get; set; }
        public static UInt32 NAME_MapProperty { get; set; }

        internal static void Set(List<FNameEntrySerialized> nameMap)
        {
            for (int i = 0; i < nameMap.Count; i++)
            {
                string name = nameMap[i].Name.Value;
                if (name == "None")
                {
                    None = new FName { ComparisonIndex = new() { Value = (uint)i } };
                }
                else if (name == "StructProperty")
                {
                    NAME_StructProperty = (uint)i;
                }
                else if (name == "BoolProperty")
                {
                    NAME_BoolProperty = (uint)i;
                }
                else if (name == "ByteProperty")
                {
                    NAME_ByteProperty = (uint)i;
                }
                else if (name == "EnumProperty")
                {
                    NAME_EnumProperty = (uint)i;
                }
                else if (name == "ArrayProperty")
                {
                    NAME_ArrayProperty = (uint)i;
                }
                else if (name == "OptionalProperty")
                {
                    NAME_OptionalProperty = (uint)i;
                }
                else if (name == "SetProperty")
                {
                    NAME_SetProperty = (uint)i;
                }
                else if (name == "MapProperty")
                {
                    NAME_MapProperty = (uint)i;
                }
                Names.Add(name);
            }
        }
    }
}

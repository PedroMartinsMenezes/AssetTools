using AssetTool.Model.Const;

namespace AssetTool
{
    public static class GlobalNames
    {
        private static List<string> NamesList { get; set; } = new();
        private static Dictionary<string, uint> NamesDict { get; set; } = new();

        public static bool IsFilled(FNameEntryId x) => x.Value < (uint)NamesList.Count && x.Value != None.ComparisonIndex.Value;

        public static bool IsValid(FNameEntryId x) => x.Value < (uint)NamesList.Count;

        public static string Get(FNameEntryId x) => x.Value < (uint)NamesList.Count ? NamesList[(int)x.Value] : null;

        public static string Get(FName x) => NamesList[(int)x.ComparisonIndex.Value];

        public static string Get(UInt32 x) => NamesList[(int)x];

        public static uint GetIndex(string x)
        {
            if (x.Length > 2)
            {
                if (char.IsDigit(x[x.Length - 1]) && x[x.Length - 2] == '_')
                {
                    x = x.Substring(0, x.Length - 2);
                }
                else if (char.IsDigit(x[x.Length - 1]) && char.IsDigit(x[x.Length - 2]) && x[x.Length - 3] == '_')
                {
                    x = x.Substring(0, x.Length - 3);
                }
                else if (char.IsDigit(x[x.Length - 1]) && char.IsDigit(x[x.Length - 2]) && char.IsDigit(x[x.Length - 3]) && x[x.Length - 4] == '_')
                {
                    x = x.Substring(0, x.Length - 4);
                }
                else if (char.IsDigit(x[x.Length - 1]) && char.IsDigit(x[x.Length - 2]) && char.IsDigit(x[x.Length - 3]) && char.IsDigit(x[x.Length - 4]) && x[x.Length - 5] == '_')
                {
                    x = x.Substring(0, x.Length - 5);
                }
            }
            return NamesDict[x];
        }

        public static FName None { get; set; }

        public static UInt32 NAME_ArrayProperty { get; set; }
        public static UInt32 NAME_BoolProperty { get; set; }
        public static UInt32 NAME_ByteProperty { get; set; }
        public static UInt32 NAME_EnumProperty { get; set; }
        public static UInt32 NAME_MapProperty { get; set; }
        public static UInt32 NAME_OptionalProperty { get; set; }
        public static UInt32 NAME_SetProperty { get; set; }
        public static UInt32 NAME_StructProperty { get; set; }

        internal static void Set(List<FNameEntrySerialized> nameMap)
        {
            for (int i = 0; i < nameMap.Count; i++)
            {
                string name = nameMap[i].Name.Value;
                if (name == Consts.None)
                    None = new FName { ComparisonIndex = new() { Value = (uint)i } };
                else if (name == Consts.StructProperty)
                    NAME_StructProperty = (uint)i;
                else if (name == Consts.BoolProperty)
                    NAME_BoolProperty = (uint)i;
                else if (name == Consts.ByteProperty)
                    NAME_ByteProperty = (uint)i;
                else if (name == Consts.EnumProperty)
                    NAME_EnumProperty = (uint)i;
                else if (name == Consts.ArrayProperty)
                    NAME_ArrayProperty = (uint)i;
                else if (name == Consts.OptionalProperty)
                    NAME_OptionalProperty = (uint)i;
                else if (name == Consts.SetProperty)
                    NAME_SetProperty = (uint)i;
                else if (name == Consts.MapProperty)
                    NAME_MapProperty = (uint)i;

                NamesList.Add(name);
                NamesDict.Add(name, (uint)i);
            }
        }
    }
}

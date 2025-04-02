using System.Text.RegularExpressions;

namespace AssetTool
{
    public class GlobalNames
    {
        private Dictionary<string, uint> NamesDict { get; set; } = new();
        private Dictionary<uint, string> IndicesDict { get; set; } = new();

        public bool IsFilled(FNameEntryId x) => x.Value < (uint)IndicesDict.Count && x.Value != None.ComparisonIndex.Value;

        public bool IsValid(FNameEntryId x) => x.Value < (uint)IndicesDict.Count;

        public bool Contains(string name) => NamesDict.ContainsKey(name);

        public string Get(FNameEntryId x) => x.Value < (uint)IndicesDict.Count ? IndicesDict[x.Value] : null;

        public string Get(FName x) => IndicesDict[x.ComparisonIndex.Value];

        public string Get(UInt32 x) => IndicesDict[x];

        public (uint, uint) GetIndexAndNumber(string name)
        {
            if (Regex.Match(name, "(.*)_0$") is var match1 && match1.Success)
            {
                uint index = NamesDict[match1.Groups[1].Value];
                uint number = 1;
                return (index, number);
            }
            else if (Regex.Match(name, "(.*)_([1-9][0-9]*)$") is var match2 && match2.Success)
            {
                uint index = NamesDict[match2.Groups[1].Value];
                uint number = 1 + uint.Parse(match2.Groups[2].Value);
                return (index, number);
            }
            else if (NamesDict.TryGetValue(name, out uint index))
            {
                return (index, 0);
            }
            else
            {
                throw new InvalidOperationException($"Name not found in dictionary: '{name}'");
            }
        }

        public bool TryGetIndex(string x, out uint index)
        {
            return NamesDict.TryGetValue(x, out index);
        }

        public FName None { get; set; }

        public UInt32 NAME_ArrayProperty { get; set; }
        public UInt32 NAME_BoolProperty { get; set; }
        public UInt32 NAME_ByteProperty { get; set; }
        public UInt32 NAME_EnumProperty { get; set; }
        public UInt32 NAME_MapProperty { get; set; }
        public UInt32 NAME_OptionalProperty { get; set; }
        public UInt32 NAME_SetProperty { get; set; }
        public UInt32 NAME_StructProperty { get; set; }

        internal void Set(List<FNameEntrySerialized> nameMap)
        {
            if (NamesDict.Any())
                return;
            for (int i = 0; i < nameMap.Count; i++)
            {
                string name = nameMap[i].Name.Value;
                if (name == Consts.None)
                    None = new FName { Value = "None", ComparisonIndex = new() { Value = (uint)i } };
                else if (name == FStructProperty.TYPE_NAME)
                    NAME_StructProperty = (uint)i;
                else if (name == FBoolProperty.TYPE_NAME)
                    NAME_BoolProperty = (uint)i;
                else if (name == FByteProperty.TYPE_NAME)
                    NAME_ByteProperty = (uint)i;
                else if (name == FEnumProperty.TYPE_NAME)
                    NAME_EnumProperty = (uint)i;
                else if (name == Consts.ArrayProperty)
                    NAME_ArrayProperty = (uint)i;
                else if (name == Consts.OptionalProperty)
                    NAME_OptionalProperty = (uint)i;
                else if (name == Consts.SetProperty)
                    NAME_SetProperty = (uint)i;
                else if (name == Consts.MapProperty)
                    NAME_MapProperty = (uint)i;

                IndicesDict[(uint)i] = name;
                NamesDict[name] = (uint)i;
            }
        }

        public void Clear()
        {
            IndicesDict.Clear();
            NamesDict.Clear();
        }
    }
}

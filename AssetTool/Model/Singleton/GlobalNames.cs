namespace AssetTool
{
    public class GlobalNames
    {
        public Dictionary<string, uint> NameToIndex { get; set; } = new();
        public Dictionary<uint, string> IndexToName { get; set; } = new();

        public Dictionary<string, (uint, uint)> NameToIndexMap { get; set; } = new();

        public bool IsFilled(FNameEntryId x) => x.Value < (uint)IndexToName.Count && x.Value != None.ComparisonIndex.Value;

        public bool IsValid(FNameEntryId x) => x.Value < (uint)IndexToName.Count;

        public bool Contains(string name) => NameToIndex.ContainsKey(name);

        public string Get(FNameEntryId x) => x.Value < (uint)IndexToName.Count ? IndexToName[x.Value] : null;

        public string Get(FName x) => IndexToName[x.ComparisonIndex.Value];

        public string Get(UInt32 x) => IndexToName[x];

        //public (uint, uint) GetIndexAndNumber(string name)
        //{
        //    if (Regex.Match(name, "(.*)_0$") is var match1 && match1.Success)
        //    {
        //        uint index = NameToIndex[match1.Groups[1].Value];
        //        uint number = 1;
        //        return (index, number);
        //    }
        //    else if (Regex.Match(name, "(.*)_([1-9][0-9]*)$") is var match2 && match2.Success)
        //    {
        //        uint index = NameToIndex[match2.Groups[1].Value];
        //        uint number = 1 + uint.Parse(match2.Groups[2].Value);
        //        return (index, number);
        //    }
        //    else if (NameToIndex.TryGetValue(name, out uint index))
        //    {
        //        return (index, 0);
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException($"Name not found in dictionary: '{name}'");
        //    }
        //}

        //public bool TryGetIndex(string x, out uint index)
        //{
        //    return NameToIndex.TryGetValue(x, out index);
        //}

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
            if (NameToIndex.Any())
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

                IndexToName[(uint)i] = name;
                NameToIndex[name] = (uint)i;
            }
        }

        public void Clear()
        {
            IndexToName.Clear();
            NameToIndex.Clear();
        }
    }
}

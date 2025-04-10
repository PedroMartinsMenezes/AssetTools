namespace AssetTool
{
    public class BasePropertyJson<T> : Dictionary<string, object>, IPropertytag
    {
        public string Pattern = "(?:\\((\\S+)\\))?\\s*'(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:{([-a-fA-F0-9]+)})?";
        public virtual string Name { get; }
        public virtual int Size { get; }
        public virtual string TypeName { get; }
        public virtual string StructName { get; }
        public virtual object DerivedValue(object value) => value;
        public virtual object BaseValue(Transfer transfer, object value) => value;

        public BasePropertyJson() { }

        public object SetNative(FPropertyTag tag)
        {
            string enumName = tag.EnumName is null ? " " : $" ({tag.EnumName.Value}) ";
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" {{{tag.GuidValue}}}";
            object value = TypeName == FBoolProperty.TYPE_NAME ? tag.BoolVal == 1 : DerivedValue(tag.Value);
            Add($"{Name}{enumName}'{tag.Name.ToString()}'{arrayIndex}{guidValue}", value);
            return this;
        }

        public FPropertyTag GetNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), Values.First());
        }

        public FPropertyTag GetNative(Transfer transfer, string key, object value)
        {
            string name, enumName, index, guid;
            byte boolVal;
            GetMembers(key, value, out name, out enumName, out boolVal, out index, out guid);
            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                EnumName = enumName.Length > 0 ? new FName(enumName, transfer) : null,
                Type = new FName(TypeName, transfer),
                StructName = StructName is { } ? new FName(StructName, transfer) : default,
                BoolVal = boolVal,
                Value = BaseValue(transfer, value),
                Size = Size,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
            };
        }

        private void GetMembers(string key, object value, out string name, out string enumName, out byte boolVal, out string index, out string guid)
        {
            int name1 = key.IndexOf('\'');
            int name2 = name1 == -1 ? -1 : key.IndexOf('\'', name1 + 1);
            int enumName1 = key.IndexOf('(') is var validEnumName1 && validEnumName1 < name1 ? validEnumName1 : -1;
            int enumName2 = key.IndexOf(')') is var validEnumName2 && validEnumName2 < name1 ? validEnumName2 : -1;
            int index1 = key.IndexOf('[') is var validIndex1 && validIndex1 > name2 ? validIndex1 : -1;
            int index2 = index1 == -1 ? -1 : key.IndexOf(']') is var validIndex2 && validIndex2 > name2 ? validIndex2 : -1;
            int guid1 = key.IndexOf('{') is var validGuid1 && validGuid1 > name2 ? validGuid1 : -1;
            int guid2 = guid1 == -1 ? -1 : key.IndexOf('}') is var validGuid2 && validGuid2 > name2 ? validGuid2 : -1;

            boolVal = TypeName == FBoolProperty.TYPE_NAME ? (Convert.ToBoolean(value) ? (byte)1 : (byte)0) : (byte)0;
            name = name1 > 0 && name2 > 0 ? key[(name1 + 1)..(name2)] : null;
            enumName = enumName1 > 0 && enumName2 > 0 ? key[(enumName1 + 1)..(enumName2)] : string.Empty;
            index = index1 > 0 && index2 > 0 ? key[(index1 + 1)..(index2)] : string.Empty;
            guid = guid1 > 0 && guid2 > 0 ? key[(guid1 + 1)..(guid2)] : string.Empty;
        }
    }
}

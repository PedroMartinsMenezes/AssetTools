namespace AssetTool
{
    public class BasePropertyJsonArray<T> : Dictionary<string, object>, IPropertytag
    {
        public string Pattern = "(?:\\((\\S+)\\))?\\s*'(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:{([-a-fA-F0-9]+)})?";
        public virtual string Name { get; }
        public virtual int Size { get; }
        public virtual string InnerTypeName { get; }
        public virtual string StructName { get; }
        public virtual string ItemToString(object item) => item.ToString();
        public virtual object StringToItem<T2>(string str) => Convert.ChangeType(str, typeof(T2));

        public BasePropertyJsonArray() { }

        public BasePropertyJsonArray(FPropertyTag tag)
        {
            string key = BasePropertyJson.BuildKey(Name, tag);
            string values = string.Join(' ', (tag.Value as List<object>).Select(x => ItemToString(x)));
            Add(key, values);
        }

        public FPropertyTag GetNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), (string)Values.First());
        }

        public FPropertyTag GetNative(Transfer transfer, string key, string value)
        {
            string name, enumName, index, guid, enumInnerType, typeNamespace;
            ExtractKey(key, out name, out enumName, out index, out guid, out enumInnerType, out typeNamespace);
            byte hasPropertyGuid = (byte)(guid is { } ? 1 : 0);
            int arrayIndex = index is { } ? int.Parse(index) : 0;
            FPropertyTypeName typeName = BasePropertyJson.ExtractTypeName(transfer, Consts.ArrayProperty, enumName, StructName, InnerTypeName, default, name, enumInnerType, typeNamespace);
            EPropertyTagFlags propertyTagFlags = BasePropertyJson.ExtractPropertyTagFlags(0, hasPropertyGuid, arrayIndex, StructName);
            EPropertyTagSerializeType serializeType = BasePropertyJson.ExtractSerializeType(propertyTagFlags);
            List<object> values = value.Length == 0 ? [] : value.Split(' ').Select(x => StringToItem<T>(x)).ToList();
            int size = 4 + values.Count * Size;

            FPropertyTag maybeInnerTag = default;
            if (StructName is { })
            {
                maybeInnerTag = new()
                {
                    Name = new FName(name, transfer),
                    Type = new FName(InnerTypeName, transfer),
                    Size = size - 4,
                    StructName = new FName(StructName, transfer),
                    PropertyTagFlags = propertyTagFlags,
                    SerializeType = serializeType,
                };

                size += maybeInnerTag.HeaderSize(transfer);
            }

            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                EnumName = enumName is { } ? new FName(enumName, transfer) : new FName("None", transfer),
                Type = new FName(Consts.ArrayProperty, transfer),
                InnerType = new FName(InnerTypeName, transfer),
                BoolVal = 0,
                Value = values,
                Size = size,
                ArrayIndex = arrayIndex,
                HasPropertyGuid = hasPropertyGuid,
                PropertyGuid = guid is { } ? new FGuid(guid) : default,
                MaybeInnerTag = maybeInnerTag,
                TypeName = typeName,
                PropertyTagFlags = propertyTagFlags,
                SerializeType = serializeType,
            };
        }

        private static void ExtractKey(string key, out string name, out string enumName, out string index, out string guid, out string enumInnerType, out string typeNamespace)
        {
            int space = key.IndexOf(' ');
            int name1 = key.IndexOf('\'');
            int name2 = name1 == -1 ? -1 : key.IndexOf('\'', name1 + 1);
            int enumName1 = key.IndexOf('(') is var validEnumName1 && validEnumName1 < name1 ? validEnumName1 : -1;
            int enumName2 = key.IndexOf(')') is var validEnumName2 && validEnumName2 < name1 ? validEnumName2 : -1;
            int index1 = key.IndexOf('[', space) is var validIndex1 && validIndex1 > name2 ? validIndex1 : -1;
            int index2 = index1 == -1 ? -1 : key.IndexOf(']', space) is var validIndex2 && validIndex2 > name2 ? validIndex2 : -1;
            int guid1 = key.IndexOf('{') is var validGuid1 && validGuid1 > name2 ? validGuid1 : -1;
            int guid2 = guid1 == -1 ? -1 : key.IndexOf('}') is var validGuid2 && validGuid2 > name2 ? validGuid2 : -1;

            name = name1 > 0 && name2 > 0 ? key[(name1 + 1)..(name2)] : default;
            enumName = enumName1 > 0 && enumName2 > 0 ? key[(enumName1 + 1)..(enumName2)] : default;
            index = index1 > 0 && index2 > 0 ? key[(index1 + 1)..(index2)] : default;
            guid = guid1 > 0 && guid2 > 0 ? key[(guid1 + 1)..(guid2)] : default;

            int lastIndex = Math.Max(name2, Math.Max(index2, guid2)) + 1;

            enumInnerType = default;
            typeNamespace = default;

            if (lastIndex < key.Length - 1)
            {
                if (enumName == default)
                {
                    typeNamespace = key[lastIndex] != '.' ? key.Substring(lastIndex + 1) : default;
                }
                else
                {
                    string suffix = key[lastIndex] != '.' ? key.Substring(lastIndex + 1) : default;
                    if (suffix is { })
                    {
                        string[] parts = suffix.Split(' ');
                        if (parts.Length == 2)
                        {
                            enumInnerType = suffix.Split(' ')[0];
                            typeNamespace = suffix.Split(' ')[1];
                        }
                        else
                        {
                            typeNamespace = suffix.Split(' ')[0];
                        }
                    }
                }
            }
        }
    }
}

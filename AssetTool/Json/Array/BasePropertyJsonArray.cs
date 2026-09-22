using System.Globalization;

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
        public virtual object StringToItem<T2>(string str) => Convert.ChangeType(str, typeof(T2), CultureInfo.InvariantCulture);

        public BasePropertyJsonArray() { }

        public BasePropertyJsonArray(FPropertyTag tag)
        {
            string key = new BasePropertyJson().BuildKey(Name, tag);
            string values = string.Join(' ', (tag.Value as List<object>).Select(x => ItemToString(x)));
            Add(key, values);
        }

        public FPropertyTag ToNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), (string)Values.First());
        }

        public FPropertyTag GetNative(Transfer transfer, string key, string value)
        {
            string name, enumName, index, guid, enumInnerType, typeNamespace;
            BasePropertyJson.ExtractKey(key, out name, out enumName, out index, out guid, out enumInnerType, out typeNamespace);
            byte hasPropertyGuid = (byte)(guid is { } ? 1 : 0);
            int arrayIndex = index is { } ? int.Parse(index) : 0;
            FPropertyTypeName typeName = BasePropertyJson.ExtractTypeName(transfer, Consts.ArrayProperty, enumName, StructName, InnerTypeName, default, name, enumInnerType, typeNamespace);
            EPropertyTagFlags propertyTagFlags = BasePropertyJson.ExtractPropertyTagFlags(0, hasPropertyGuid, arrayIndex, StructName);
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
                };

                size += maybeInnerTag.HeaderSize(transfer);
            }

            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                EnumName = enumName is { } ? new FName(enumName, transfer) : new FName("None", transfer),
                Type = new FName(Consts.ArrayProperty, transfer),
                InnerType = new FName(InnerTypeName, transfer),
                BoolVal = null,
                Value = values,
                Size = size,
                ArrayIndex = arrayIndex > 0 ? arrayIndex : null,
                HasPropertyGuid = hasPropertyGuid == 1 ? 1 : null,
                PropertyGuid = guid is { } ? new FGuid(guid) : default,
                MaybeInnerTag = maybeInnerTag,
                TypeName = typeName,
                PropertyTagFlags = propertyTagFlags,
            };
        }
    }
}

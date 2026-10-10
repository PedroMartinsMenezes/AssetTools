using System.Globalization;
using System.Text;

namespace AssetTool
{
    public class BasePropertyJsonArray : Dictionary<string, object>, IPropertytag
    {
        public string Pattern = "(?:\\((\\S+)\\))?\\s*'(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:{([-a-fA-F0-9]+)})?";
        public virtual string Name { get; }
        public virtual int Size { get; }
        public virtual string InnerTypeName { get; }
        public virtual string StructName { get; }
        public virtual string Separator => " ";
        public virtual string ItemToString(object item) => item.ToString();
        public virtual object StringToItem(string str) => Convert.ChangeType(str, typeof(object), CultureInfo.InvariantCulture);
        // Overridden by item types that can be formatted/parsed without an intermediate string per item.
        public virtual void AppendItem(StringBuilder builder, object item) => builder.Append(ItemToString(item));
        public virtual object SpanToItem(ReadOnlySpan<char> str) => StringToItem(str.ToString());
        public virtual string FromNativeFields(FPropertyTag tag) => string.Empty;
        public virtual void ToNativeFields(FPropertyTag tag, string key) { }

        public BasePropertyJsonArray() { }

        public virtual object FromNativeValue(FPropertyTag tag)
        {
            List<object> list = tag.Value as List<object>;
            StringBuilder builder = new();
            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                    builder.Append(Separator);
                AppendItem(builder, list[i]);
            }
            return builder.ToString();
        }

        public virtual object FromNative(FPropertyTag tag, Transfer transfer = null)
        {
            string key = new BasePropertyJson().BuildKey(Name, tag, FromNativeFields);
            object value = FromNativeValue(tag);
            Add(key, value);
            return this;
        }

        public virtual FPropertyTag ToNative(Transfer transfer)
        {
            return ToNative(transfer, Keys.First(), (string)Values.First());
        }

        public virtual List<object> ToNativeValue(object val)
        {
            string value = val.ToString();
            if (value.Length == 0)
                return [];
            string separator = Separator;
            if (separator.Length == 0)
                return [StringToItem(value)];
            ReadOnlySpan<char> rest = value;
            List<object> values = new(rest.Count(separator) + 1);
            while (true)
            {
                int index = rest.IndexOf(separator);
                if (index < 0)
                {
                    values.Add(SpanToItem(rest));
                    return values;
                }
                values.Add(SpanToItem(rest[..index]));
                rest = rest[(index + separator.Length)..];
            }
        }

        public virtual FPropertyTag ToNative(Transfer transfer, string key, object val)
        {
            string name, native, enumName, index, guid, enumInnerType, typeNamespace;
            BasePropertyJson.ExtractKey(transfer, null, key, out name, out native, out enumName, out index, out guid, out enumInnerType, out typeNamespace);
            byte hasPropertyGuid = (byte)(guid is { } ? 1 : 0);
            int arrayIndex = index is { } ? int.Parse(index) : 0;
            FPropertyTypeName typeName = BasePropertyJson.ExtractTypeName(transfer, FArrayProperty.TYPE_NAME, enumName, StructName, InnerTypeName, default, name, enumInnerType, typeNamespace);
            EPropertyTagFlags? propertyTagFlags = BasePropertyJson.ExtractPropertyTagFlags(0, hasPropertyGuid, arrayIndex, native);

            List<object> values = ToNativeValue(val);

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

            var tag = new FPropertyTag
            {
                Name = new FName(name, transfer),
                EnumName = enumName is { } ? new FName(enumName, transfer) : new FName("None", transfer),
                Type = new FName(FArrayProperty.TYPE_NAME, transfer),
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

            ToNativeFields(tag, key);

            return tag;
        }
    }
}

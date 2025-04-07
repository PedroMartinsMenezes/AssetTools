using System.Globalization;

namespace AssetTool
{
    public class BasePropertyJsonArray<T> : Dictionary<string, object>, IPropertytag
    {
        public string Pattern = "(?:\\((\\S+)\\))?\\s*'(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:{([-a-fA-F0-9]+)})?";
        public virtual string Name { get; }
        public virtual int Size { get; }
        public virtual string InnerTypeName { get; set; }

        public BasePropertyJsonArray() { }

        public BasePropertyJsonArray(FPropertyTag tag)
        {
            string enumName = tag.EnumName is null ? " " : $" ({tag.EnumName.Value}) ";
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" {{{tag.GuidValue}}}";

            string values = null;
            if (typeof(T) == typeof(float))
            {
                values = string.Join(' ', (tag.Value as List<object>).Select(x => ((float)x).ToString(CultureInfo.InvariantCulture)));
            }
            else if (typeof(T) == typeof(double))
            {
                values = string.Join(' ', (tag.Value as List<object>).Select(x => ((double)x).ToString(CultureInfo.InvariantCulture)));
            }
            else
            {
                values = string.Join(' ', (tag.Value as List<object>).Select(x => x.ToString()));
            }
            Add($"{Name}{enumName}'{tag.Name.ToString()}'{arrayIndex}{guidValue}", values);
        }

        public FPropertyTag GetNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), (string)Values.First());
        }

        public FPropertyTag GetNative(Transfer transfer, string key, string value)
        {
            string name, enumName, index, guid;
            GetValues(key, out name, out enumName, out index, out guid);
            List<object> values = [];
            if (typeof(T) == typeof(float))
            {
                values = value.Length == 0 ? [] : value.Split(' ').Select(x => (object)float.Parse(x, CultureInfo.InvariantCulture)).ToList();
            }
            else if (typeof(T) == typeof(double))
            {
                values = value.Length == 0 ? [] : value.Split(' ').Select(x => (object)double.Parse(x, CultureInfo.InvariantCulture)).ToList();
            }
            else
            {
                values = value.Length == 0 ? [] : value.Split(' ').Select(x => Convert.ChangeType(x, typeof(T))).ToList();
            }
            int size = 4 + values.Count * Size;
            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                EnumName = enumName.Length > 0 ? new FName(enumName, transfer) : null,
                Type = new FName(Consts.ArrayProperty, transfer),
                InnerType = new FName(InnerTypeName, transfer),
                BoolVal = 0,
                Value = values,
                Size = size,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
            };
        }

        private static void GetValues(string key, out string name, out string enumName, out string index, out string guid)
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

            name = name1 > 0 && name2 > 0 ? key[(name1 + 1)..(name2)] : null;
            enumName = enumName1 > 0 && enumName2 > 0 ? key[(enumName1 + 1)..(enumName2)] : string.Empty;
            index = index1 > 0 && index2 > 0 ? key[(index1 + 1)..(index2)] : string.Empty;
            guid = guid1 > 0 && guid2 > 0 ? key[(guid1 + 1)..(guid2)] : string.Empty;
        }
    }
}

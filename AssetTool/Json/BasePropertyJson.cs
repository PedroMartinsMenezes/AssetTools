using System.Text.RegularExpressions;

namespace AssetTool
{
    public class BasePropertyJson<T> : Dictionary<string, object>, IPropertytag
    {
        public string Pattern = "(?:\\((\\S+)\\))?\\s*'(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";
        public virtual string Name { get; }
        public virtual int Size { get; }
        public virtual string TypeName { get; set; }

        public BasePropertyJson() { }

        public BasePropertyJson(FPropertyTag tag)
        {
            string enumName = tag.EnumName is null ? " " : $" ({tag.EnumName.Value}) ";
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            object value = TypeName == FBoolProperty.TYPE_NAME ? tag.BoolVal == 1 : tag.Value;
            Add($"{Name}{enumName}'{tag.Name.ToString()}'{arrayIndex}{guidValue}", value);
        }

        public FPropertyTag GetNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), (T)Values.First());
        }

        public FPropertyTag GetNative(Transfer transfer, string key, T value)
        {
            string name, enumName, index, guid;
            byte boolVal;
            GetValues(key, value, out name, out enumName, out boolVal, out index, out guid);
            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                EnumName = enumName.Length > 0 ? new FName(enumName, transfer) : null,
                Type = new FName(TypeName, transfer),
                BoolVal = boolVal,
                Value = value,
                Size = Size,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
            };
        }

        private void GetValues(string key, T value, out string name, out string enumName, out byte boolVal, out string index, out string guid)
        {
            if (!key.Contains('(') && !key.Contains('['))
            {
                name = key[(key.IndexOf('\'') + 1)..^1];
                enumName = string.Empty;
                boolVal = TypeName == FBoolProperty.TYPE_NAME ? (Convert.ToBoolean(value) ? (byte)1 : (byte)0) : (byte)0;
                index = string.Empty;
                guid = string.Empty;
            }
            else
            {
                var match = Regex.Match(key, $"{Name} {Pattern}");
                name = match.Groups[2].Value;
                enumName = match.Groups[1].Value;
                boolVal = TypeName == FBoolProperty.TYPE_NAME ? (Convert.ToBoolean(value) ? (byte)1 : (byte)0) : (byte)0;
                index = match.Groups[3].Value;
                guid = match.Groups[4].Value;
            }
        }
    }
}

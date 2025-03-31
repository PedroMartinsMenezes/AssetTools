using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("byte8[]")]
    public class FByte8PropertyJsonArray : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "byte8\\[\\] '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FByte8PropertyJsonArray() { }

        public FByte8PropertyJsonArray(FPropertyTag tag)
        {
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            string values = string.Join(' ', (tag.Value as List<object>).Select(x => x.ToString()));
            Add($"byte8[] '{tag.Name.ToString()}'{arrayIndex}{guidValue}", values);
        }

        public FPropertyTag GetNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), (string)Values.First());
        }

        public static FPropertyTag GetNative(Transfer transfer, string key, string value)
        {
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            List<object> values = value.Length == 0 ? [] : value.Split(' ').Select(x => (object)ulong.Parse(x)).ToList();
            int size = 4 + values.Count * 8;

            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                Type = new FName(Consts.ArrayProperty, transfer),
                InnerType = new FName(FByteProperty.TYPE_NAME, transfer),
                Value = values,
                Size = size,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
            };
        }
    }
}

using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("float[]")]
    public class FFloatPropertyJsonArray : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "float\\[\\] '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FFloatPropertyJsonArray() { }

        public FFloatPropertyJsonArray(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            string values = string.Join(' ', (tag.Value as List<object>).Select(x => x.ToString()));
            Add($"float[] '{tag.Name.ToString()}'{arrayIndex}{guidValue}", values);
        }

        public FPropertyTag GetNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), (string)Values.First());
        }

        public static FPropertyTag GetNative(Transfer transfer, string key, string value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            List<object> values = value.Length == 0 ? [] : value.Split(' ').Select(x => (object)float.Parse(x)).ToList();
            int size = 4 + values.Count * 4;

            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                Type = new FName(Consts.ArrayProperty, transfer),
                InnerType = new FName(FFloatProperty.TYPE_NAME, transfer),
                Value = values,
                Size = size,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
            };
        }
    }
}

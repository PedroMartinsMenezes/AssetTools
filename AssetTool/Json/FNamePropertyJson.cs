using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("name")]
    public class FNamePropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "name '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FNamePropertyJson() { }

        public FNamePropertyJson(FPropertyTag tag)
        {
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            Add($"name '{tag.Name.ToString()}'{arrayIndex}{guidValue}", ((FName)tag.Value).ToString());
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), (string)Values.First());
        }

        public static FPropertyTag GetNative(string key, string value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FNameProperty.TYPE_NAME),
                Size = 8,
                Value = new FName(value),
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }
}

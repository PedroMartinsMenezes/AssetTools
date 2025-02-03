using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("byte")]
    public class FByte8PropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "byte (?:\\((\\S+)\\))?\\s*'(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FByte8PropertyJson() { }

        public FByte8PropertyJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string enumName = tag.EnumName.Value.Length == 0 ? string.Empty : $"({tag.EnumName.Value}) ";
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            Add($"byte {enumName}'{tag.Name.ToString()}'{arrayIndex}{guidValue}", tag.Value);
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), (byte)Values.First());
        }

        public static FPropertyTag GetNative(string key, byte value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, Pattern);
            string enumName = match.Groups[1].Value;
            string name = match.Groups[2].Value;
            string index = match.Groups[3].Value;
            string guid = match.Groups[4].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                EnumName = enumName.Length > 0 ? new FName(enumName) : null,
                Type = new FName(FByteProperty.TYPE_NAME),
                Value = value,
                Size = 1,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }
}

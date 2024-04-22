using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public class FByte32PropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "byte32 (?:(\\w+))?\\s*'([ \\w]+)'\\s*(?:\\(([-A-F0-9]+)\\))?";

        public FByte32PropertyJson() { }

        public FByte32PropertyJson(FPropertyTag tag)
        {
            Add($"byte32 {tag.EnumName.Value} '{tag.Name.Value}'", tag.Value);
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), (UInt32)Values.First());
        }

        public static FPropertyTag GetNative(string key, UInt32 value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, FFloatPropertyJson.Pattern);
            string name = match.Groups[1].Value;
            string enumName = match.Groups[2].Value;
            string index = match.Groups[3].Value;
            string guid = match.Groups[4].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                EnumName = enumName.Length > 0 ? new FName(enumName) : null,
                Type = new FName(FByteProperty.TYPE_NAME),
                Value = value,
                Size = 4,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }
}

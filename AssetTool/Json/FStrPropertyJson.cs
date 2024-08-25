using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public class FStrPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "string '([\\w]+)'";

        public FStrPropertyJson() { }

        public FStrPropertyJson(FPropertyTag tag)
        {
            Add($"string '{tag.Name.ToString()}'", ((FString)tag.Value).ToString());
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
            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FStrProperty.TYPE_NAME),
                Size = value.SerializedSize(),
                Value = new FString(value),
            };
        }
    }
}

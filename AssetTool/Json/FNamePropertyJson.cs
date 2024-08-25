using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public class FNamePropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "name '([\\w]+)'";

        public FNamePropertyJson() { }

        public FNamePropertyJson(FPropertyTag tag)
        {
            Add($"name '{tag.Name.ToString()}'", ((FName)tag.Value).ToString());
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
                Type = new FName(FNameProperty.TYPE_NAME),
                Size = 8,
                Value = new FName(value),
            };
        }
    }
}

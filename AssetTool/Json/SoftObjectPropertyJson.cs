using System.Text.RegularExpressions;

namespace AssetTool
{
    public class SoftObjectPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "soft '([\\w]+)'";

        public SoftObjectPropertyJson() { }

        public SoftObjectPropertyJson(FPropertyTag tag)
        {
            Add($"soft '{tag.Name.ToString()}'", tag.Value);
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), (uint)Values.First());
        }

        public static FPropertyTag GetNative(string key, uint value)
        {
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FSoftObjectProperty.TYPE_NAME),
                Size = 4,
                Value = value,
            };
        }
    }
}

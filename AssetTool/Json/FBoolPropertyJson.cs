using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public class FBoolPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "bool '([ \\w]+)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FBoolPropertyJson() { }

        public FBoolPropertyJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            Add($"bool '{tag.Name.Value}'{arrayIndex}{guidValue}", tag.BoolVal == 1);
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), (bool)Values.First());
        }

        public static FPropertyTag GetNative(string key, bool value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, FFloatPropertyJson.Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FDoubleProperty.TYPE_NAME),
                Value = value,
                Size = 8,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }

        //public FBoolPropertyJson() { }

        //public FBoolPropertyJson(FPropertyTag tag)
        //{
        //    Add($"bool {tag.Name.Value}", tag.BoolVal == 1);
        //}

        //public FPropertyTag GetNative()
        //{
        //    string[] typeName = Keys.First().Split(' ');
        //    string name = typeName[1];
        //    bool value = bool.Parse(Values.First().ToString());

        //    return new FPropertyTag { Name = new FName(name), Type = new FName(FBoolProperty.TYPE_NAME), BoolVal = (byte)(value ? 1 : 0) };
        //}

        //public static FPropertyTag GetNative(string[] v)
        //{
        //    return new FPropertyTag { Name = new FName(v[1]), Type = new FName(FBoolProperty.TYPE_NAME), BoolVal = bool.Parse(v[2]) ? (byte)1 : (byte)0 };
        //}
    }
}

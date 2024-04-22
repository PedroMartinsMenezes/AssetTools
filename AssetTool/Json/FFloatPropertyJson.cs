using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public class FFloatPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "float ([ \\w]+)(?:\\[(\\d+)\\])?\\s*(?:\\(([-A-F0-9]+)\\))?";

        public FFloatPropertyJson() { }

        public FFloatPropertyJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            Add($"float {tag.Name.Value}{arrayIndex}{guidValue}", (float)tag.Value);
        }

        public FPropertyTag GetNative()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(Keys.First(), FFloatPropertyJson.Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FFloatProperty.TYPE_NAME),
                Value = (float)Values.First(),
                Size = 4,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }

        public static FPropertyTag GetNative(string key, float value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, FFloatPropertyJson.Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FFloatProperty.TYPE_NAME),
                Value = value,
                Size = 4,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }

        //public static FPropertyTag GetNative(string[] v)
        //{
        //    CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        //    int arrayIndex = 0;
        //    string name = string.Join(' ', v.Skip(1).Take(v.Length - 2)).Trim();
        //    float value;
        //    if (name.Contains('['))
        //    {
        //        int i1 = name.IndexOf('[') + 1;
        //        int i2 = name.IndexOf(']');
        //        arrayIndex = int.Parse(name.Substring(i1, i2 - i1));
        //        name = name.Substring(name.IndexOf(' ') + 1, i1 - name.IndexOf(' ') - 2);
        //        value = float.Parse(v[v.Length - 1], CultureInfo.InvariantCulture);
        //    }
        //    else
        //    {
        //        value = float.Parse(v[v.Length - 1], CultureInfo.InvariantCulture);
        //    }
        //    return new FPropertyTag { Name = new FName(name), Type = new FName(FFloatProperty.TYPE_NAME), Value = value, Size = 4, ArrayIndex = arrayIndex };
        //}
    }
}

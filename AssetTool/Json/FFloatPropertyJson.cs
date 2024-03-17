using System.Globalization;

namespace AssetTool
{
    public class FFloatPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public FFloatPropertyJson() { }

        public FFloatPropertyJson(FPropertyTag tag)
        {
            Add($"float {tag.Name.Value}", (float)tag.Value);
        }

        public FPropertyTag GetNative()
        {
            string name = Keys.First().Substring(Keys.First().IndexOf(' ') + 1);
            float value = (float)Values.First();
            return new FPropertyTag { Name = new FName(name), Type = new FName(FFloatProperty.TYPE_NAME), Value = value, Size = 4 };
        }

        public static FPropertyTag GetNative(string[] v)
        {
            string name = string.Join(' ', v.Skip(1).Take(v.Length - 2));
            return new FPropertyTag { Name = new FName(name), Type = new FName(FFloatProperty.TYPE_NAME), Value = float.Parse(v[v.Length - 1], CultureInfo.InvariantCulture), Size = 4 };
        }
    }
}

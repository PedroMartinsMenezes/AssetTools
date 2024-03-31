using System.Globalization;

namespace AssetTool
{
    public class FFloatPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public FFloatPropertyJson() { }

        public FFloatPropertyJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            Add($"float {tag.Name.Value}{arrayIndex}", (float)tag.Value);
        }

        public FPropertyTag GetNative()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            float value = 0;
            int arrayIndex = 0;
            string name;
            if (Keys.First().Contains('['))
            {
                int i1 = Keys.First().IndexOf('[') + 1;
                int i2 = Keys.First().IndexOf(']');
                name = Keys.First().Substring(Keys.First().IndexOf(' ') + 1, i1 - Keys.First().IndexOf(' ') - 2);
                arrayIndex = int.Parse(Keys.First().Substring(i1, i2 - i1));
            }
            else
            {
                name = Keys.First().Substring(Keys.First().IndexOf(' ') + 1);
                value = (float)Values.First();
            }
            return new FPropertyTag { Name = new FName(name), Type = new FName(FFloatProperty.TYPE_NAME), Value = value, Size = 4, ArrayIndex = arrayIndex };
        }

        public static FPropertyTag GetNative(string[] v)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            float value = 0;
            int arrayIndex = 0;
            string name = string.Join(' ', v.Skip(1).Take(v.Length - 2));
            if (name.Contains('['))
            {
                int i1 = name.IndexOf('[') + 1;
                int i2 = name.IndexOf(']');
                arrayIndex = int.Parse(name.Substring(i1, i2 - i1));
                name = name.Substring(name.IndexOf(' ') + 1, i1 - name.IndexOf(' ') - 2);
            }
            else
            {
                value = float.Parse(v[v.Length - 1], CultureInfo.InvariantCulture);
            }
            return new FPropertyTag { Name = new FName(name), Type = new FName(FFloatProperty.TYPE_NAME), Value = value, Size = 4, ArrayIndex = arrayIndex };
        }
    }
}

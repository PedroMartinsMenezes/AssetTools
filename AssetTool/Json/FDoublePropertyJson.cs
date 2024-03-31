using System.Globalization;

namespace AssetTool
{
    public class FDoublePropertyJson : Dictionary<string, object>, IPropertytag
    {
        public FDoublePropertyJson() { }

        public FDoublePropertyJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            Add($"double {tag.Name.Value}{arrayIndex}", (double)tag.Value);
        }

        public FPropertyTag GetNative()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double value = 0;
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
                value = (double)Values.First();
            }
            return new FPropertyTag { Name = new FName(name), Type = new FName(FDoubleProperty.TYPE_NAME), Value = value, Size = 8, ArrayIndex = arrayIndex };
        }

        public static FPropertyTag GetNative(string[] v)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string name = string.Join(' ', v.Skip(1).Take(v.Length - 2));
            return new FPropertyTag { Name = new FName(name), Type = new FName(FDoubleProperty.TYPE_NAME), Value = double.Parse(v[v.Length - 1], CultureInfo.InvariantCulture), Size = 4 };
        }
    }
}

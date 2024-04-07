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
            int arrayIndex = 0;
            string name;
            double value;
            if (Keys.First().Contains('['))
            {
                int i1 = Keys.First().IndexOf('[') + 1;
                int i2 = Keys.First().IndexOf(']');
                name = Keys.First().Substring(Keys.First().IndexOf(' ') + 1, i1 - Keys.First().IndexOf(' ') - 2);
                arrayIndex = int.Parse(Keys.First().Substring(i1, i2 - i1));
                value = (double)Values.First();
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
            int arrayIndex = 0;
            string name = string.Join(' ', v.Skip(1).Take(v.Length - 2));
            double value;
            if (name.Contains('['))
            {
                int i1 = name.IndexOf('[') + 1;
                int i2 = name.IndexOf(']');
                arrayIndex = int.Parse(name.Substring(i1, i2 - i1));
                name = name.Substring(name.IndexOf(' ') + 1, i1 - name.IndexOf(' ') - 2);
                value = double.Parse(v[v.Length - 1], CultureInfo.InvariantCulture);
            }
            else
            {
                value = double.Parse(v[v.Length - 1], CultureInfo.InvariantCulture);
            }
            return new FPropertyTag { Name = new FName(name), Type = new FName(FDoubleProperty.TYPE_NAME), Value = value, Size = 8, ArrayIndex = arrayIndex };
        }
    }
}

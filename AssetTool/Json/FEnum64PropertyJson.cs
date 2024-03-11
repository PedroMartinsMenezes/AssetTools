namespace AssetTool
{
    public class FEnum64PropertyJson : Dictionary<string, object>, IPropertytag
    {
        public FEnum64PropertyJson() { }

        public FEnum64PropertyJson(FPropertyTag tag)
        {
            Add($"enum64 {tag.EnumName.Value} {tag.Name.Value}", tag.Value);
        }

        public FPropertyTag GetNative()
        {
            string[] args = Keys.First().Split(' ');
            string enumName = args[1];
            string name = args[2];
            UInt64 value = UInt64.Parse(Values.First().ToString());

            return new FPropertyTag { EnumName = new FName(enumName), Name = new FName(name), Type = new FName(FEnumProperty.TYPE_NAME), Value = value, Size = 8 };
        }

        public static FPropertyTag GetNative(string[] v)
        {
            return new FPropertyTag { EnumName = new FName(v[1]), Name = new FName(v[2]), Type = new FName(FEnumProperty.TYPE_NAME), Value = UInt64.Parse(v[3]), Size = 8 };
        }
    }
}

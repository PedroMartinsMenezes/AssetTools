namespace AssetTool
{
    public class FByte32PropertyJson : Dictionary<string, object>, IPropertytag
    {
        public FByte32PropertyJson() { }

        public FByte32PropertyJson(FPropertyTag tag)
        {
            Add($"byte32 {tag.EnumName.Value} {tag.Name.Value}", tag.Value);
        }

        public FPropertyTag GetNative()
        {
            string[] args = Keys.First().Split(' ');
            string enumName = args[1];
            string name = args[2];
            UInt32 value = UInt32.Parse(Values.First().ToString());

            return new FPropertyTag { EnumName = new FName(enumName), Name = new FName(name), Type = new FName(FByteProperty.TYPE_NAME), Value = value, Size = 4 };
        }

        public static FPropertyTag GetNative(string[] v)
        {
            return new FPropertyTag { EnumName = new FName(v[1]), Name = new FName(v[2]), Type = new FName(FByteProperty.TYPE_NAME), Value = UInt32.Parse(v[3]), Size = 4 };
        }
    }
}

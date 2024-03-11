namespace AssetTool
{
    public class FBoolPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public FBoolPropertyJson() { }

        public FBoolPropertyJson(FPropertyTag tag)
        {
            Add($"bool {tag.Name.Value}", tag.BoolVal == 1);
        }

        public FPropertyTag GetNative()
        {
            string[] typeName = Keys.First().Split(' ');
            string name = typeName[1];
            bool value = bool.Parse(Values.First().ToString());

            return new FPropertyTag { Name = new FName(name), Type = new FName(FBoolProperty.TYPE_NAME), BoolVal = (byte)(value ? 1 : 0) };
        }

        public static FPropertyTag GetNative(string[] v)
        {
            return new FPropertyTag { Name = new FName(v[1]), Type = new FName(FBoolProperty.TYPE_NAME), BoolVal = bool.Parse(v[2]) ? (byte)1 : (byte)0 };
        }
    }
}

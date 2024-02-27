namespace AssetTool
{
    public class FEnum32PropertyJson : Dictionary<string, object>, IPropertytag
    {
        public FEnum32PropertyJson() { }

        public FEnum32PropertyJson(FPropertyTag tag)
        {
            Add($"enum32 {tag.EnumName.Value} {tag.Name.Value}", tag.Value);
        }

        public FPropertyTag GetNative()
        {
            string[] args = Keys.First().Split(' ');
            string enumName = args[1];
            string name = args[2];
            UInt32 value = UInt32.Parse(Values.First().ToString());

            return new FPropertyTag { EnumName = new FName(enumName), Name = new FName(name), Type = new FName(FEnumProperty.TYPE_NAME), Value = value, Size = 4 };
        }
    }
}

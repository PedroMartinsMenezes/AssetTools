namespace AssetTool
{
    public class FByte64PropertyJson : Dictionary<string, object>
    {
        public FByte64PropertyJson() { }

        public FByte64PropertyJson(FPropertyTag tag)
        {
            Add($"byte64 {tag.EnumName.Value} {tag.Name.Value}", tag.Value);
        }

        public FPropertyTag GetNative()
        {
            string[] args = Keys.First().Split(' ');
            string enumName = args[1];
            string name = args[2];
            UInt64 value = UInt64.Parse(Values.First().ToString());

            return new FPropertyTag { EnumName = new FName(enumName), Name = new FName(name), Type = new FName(FByteProperty.TYPE_NAME), Value = value, Size = 8 };
        }
    }
}

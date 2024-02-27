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
            string[] typeName = Keys.First().Split(' ');
            string name = typeName[1];
            float value = (float)Values.First();

            return new FPropertyTag { Name = new FName(name), Type = new FName(FFloatProperty.TYPE_NAME), Value = value, Size = 4 };
        }
    }
}

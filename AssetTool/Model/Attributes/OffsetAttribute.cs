namespace AssetTool
{
    public class OffsetAttribute : Attribute
    {
        public OffsetAttribute(string offset, string size)
        {
            Offset = offset;
            Size = size;
        }

        public string Offset { get; }
        public string Size { get; }
    }
}

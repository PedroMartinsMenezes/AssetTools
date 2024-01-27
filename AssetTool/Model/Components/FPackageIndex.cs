namespace AssetTool
{
    public class FPackageIndex
    {
        public Int32 Index;

        public FPackageIndex() { }

        public FPackageIndex(string value)
        {
            Index = Int32.Parse(value);
        }

        public override string ToString()
        {
            return Index.ToString();
        }
    }
}

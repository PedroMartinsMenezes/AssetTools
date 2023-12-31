namespace AssetTool
{
    public class FNameShort
    {
        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;

        public FNameShort() { }

        public FNameShort(UInt32 a, UInt32 b)
        {
            ComparisonIndex.Value = a;
            Number = b;
        }

        public class FNameEntryId
        {
            public UInt32 Value;
        }
    }
}

using System.Text.Json.Serialization;

namespace AssetTool.Model.Basic
{
    public class FName
    {
        public FNameEntryId ComparisonIndex = new();
        public UInt32 Number;
        public FNameEntryId DisplayIndex = new();

        [JsonIgnore] public string Value => string.Empty;

        public FName() { }

        public FName(UInt32 a, UInt32 b, UInt32 c)
        {
            ComparisonIndex.Value = a;
            Number = b;
            DisplayIndex.Value = c;
        }

        public class FNameEntryId
        {
            public UInt32 Value;
        }
    }
}

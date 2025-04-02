using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("guid")]
    public class FGuidPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "guid '([\\w]+)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FGuidPropertyJson() { }

        public FGuidPropertyJson(FPropertyTag tag)
        {
            Add($"guid '{tag.Name.ToString()}'", tag.Value is { } ? ((FGuid)tag.Value).Value : Guid.Empty);
        }

        public FPropertyTag GetNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), (Guid)Values.First());
        }

        public static FPropertyTag GetNative(Transfer transfer, string key, Guid value)
        {
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                StructName = new FName("Guid", transfer),
                Type = new FName(FStructProperty.TYPE_NAME, transfer),
                Size = 16,
                Value = new FGuid(value),
            };
        }
    }
}

using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("bool")]
    public class FBoolPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "bool '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FBoolPropertyJson() { }

        public FBoolPropertyJson(FPropertyTag tag)
        {
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            Add($"bool '{tag.Name.ToString()}'{arrayIndex}{guidValue}", tag.BoolVal == 1);
        }

        public FPropertyTag GetNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), (bool)Values.First());
        }

        public static FPropertyTag GetNative(Transfer transfer, string key, bool value)
        {
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                Type = new FName(FBoolProperty.TYPE_NAME, transfer),
                BoolVal = (byte)(value ? 1 : 0),
                Size = 0,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
            };
        }
    }
}

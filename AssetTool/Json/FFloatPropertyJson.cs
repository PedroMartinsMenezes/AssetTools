using System.Diagnostics;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("float")]
    public class FFloatPropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "float '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FFloatPropertyJson() { }

        public FFloatPropertyJson(FPropertyTag tag)
        {
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            Add($"float '{tag.Name.ToString()}'{arrayIndex}{guidValue}", tag.Value);
        }

        public FPropertyTag GetNative(Transfer transfer)
        {
            return GetNative(transfer, Keys.First(), (float)Values.First());
        }

        public static FPropertyTag GetNative(Transfer transfer, string key, float value)
        {
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            return new FPropertyTag
            {
                Name = new FName(name, transfer),
                Type = new FName(FFloatProperty.TYPE_NAME, transfer),
                Value = value,
                Size = 4,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
            };
        }
    }
}

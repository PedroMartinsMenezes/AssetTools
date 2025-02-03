using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("ushort")]
    public class FUInt16PropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "ushort '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FUInt16PropertyJson() { }

        public FUInt16PropertyJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            Add($"ushort '{tag.Name.ToString()}'{arrayIndex}{guidValue}", tag.Value);
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), (ushort)Values.First());
        }

        public static FPropertyTag GetNative(string key, ushort value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FUInt16Property.TYPE_NAME),
                Value = value,
                Size = 2,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }
}

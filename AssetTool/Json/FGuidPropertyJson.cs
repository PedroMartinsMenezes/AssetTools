﻿using System.Diagnostics;
using System.Globalization;
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

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), (Guid)Values.First());
        }

        public static FPropertyTag GetNative(string key, Guid value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                StructName = new FName("Guid"),
                Type = new FName(FStructProperty.TYPE_NAME),
                Size = 16,
                Value = new FGuid(value),
            };
        }
    }
}

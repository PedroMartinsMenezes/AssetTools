using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("uint")]
    public class FUInt32PropertyJson : BasePropertyJson<UInt32>
    {
        public FUInt32PropertyJson() { }
        public FUInt32PropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "uint";
        public override int Size => 4;
        public override string TypeName => FUInt32Property.TYPE_NAME;
    }

    //[DebuggerDisplay("uint")]
    //public class FUInt32PropertyJson : Dictionary<string, object>, IPropertytag
    //{
    //    public const string Pattern = "uint '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

    //    public FUInt32PropertyJson() { }

    //    public FUInt32PropertyJson(FPropertyTag tag)
    //    {
    //        string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
    //        string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
    //        Add($"uint '{tag.Name.ToString()}'{arrayIndex}{guidValue}", tag.Value);
    //    }

    //    public FPropertyTag GetNative(Transfer transfer)
    //    {
    //        return GetNative(transfer, Keys.First(), (uint)Values.First());
    //    }

    //    public static FPropertyTag GetNative(Transfer transfer, string key, uint value)
    //    {
    //        var match = Regex.Match(key, Pattern);
    //        string name = match.Groups[1].Value;
    //        string index = match.Groups[2].Value;
    //        string guid = match.Groups[3].Value;
    //        return new FPropertyTag
    //        {
    //            Name = new FName(name, transfer),
    //            Type = new FName(FUInt32Property.TYPE_NAME, transfer),
    //            Value = value,
    //            Size = 4,
    //            ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
    //            HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
    //            PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
    //        };
    //    }
    //}
}

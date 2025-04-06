using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("short")]
    public class FInt16PropertyJson : BasePropertyJson<Int16>
    {
        public FInt16PropertyJson() { }
        public FInt16PropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "short";
        public override int Size => 2;
        public override string TypeName => FInt16Property.TYPE_NAME;
    }

    //[DebuggerDisplay("short")]
    //public class FInt16PropertyJson : Dictionary<string, object>, IPropertytag
    //{
    //    public const string Pattern = "short '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

    //    public FInt16PropertyJson() { }

    //    public FInt16PropertyJson(FPropertyTag tag)
    //    {
    //        string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
    //        string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
    //        Add($"short '{tag.Name.ToString()}'{arrayIndex}{guidValue}", tag.Value);
    //    }

    //    public FPropertyTag GetNative(Transfer transfer)
    //    {
    //        return GetNative(transfer, Keys.First(), (short)Values.First());
    //    }

    //    public static FPropertyTag GetNative(Transfer transfer, string key, short value)
    //    {
    //        var match = Regex.Match(key, Pattern);
    //        string name = match.Groups[1].Value;
    //        string index = match.Groups[2].Value;
    //        string guid = match.Groups[3].Value;
    //        return new FPropertyTag
    //        {
    //            Name = new FName(name, transfer),
    //            Type = new FName(FInt16Property.TYPE_NAME, transfer),
    //            Value = value,
    //            Size = 2,
    //            ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
    //            HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
    //            PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
    //        };
    //    }
    //}
}

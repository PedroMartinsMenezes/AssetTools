using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("byte32")]
    public class FByte32PropertyJson : BasePropertyJson<UInt32>
    {
        public FByte32PropertyJson() { }
        public FByte32PropertyJson(FPropertyTag tag) : base(tag) { }

        public override string Name => "byte32";
        public override int Size => 4;
        public override string TypeName => FByteProperty.TYPE_NAME;
    }

    //[DebuggerDisplay("byte32")]
    //public class FByte32PropertyJson2 : Dictionary<string, object>, IPropertytag
    //{
    //    public const string Pattern = "byte32 (?:\\((\\S+)\\))?\\s*'(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

    //    public FByte32PropertyJson2() { }

    //    public FByte32PropertyJson2(FPropertyTag tag)
    //    {
    //        string enumName = tag.EnumName.Value.Length == 0 ? string.Empty : $"({tag.EnumName.Value}) ";
    //        string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
    //        string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
    //        Add($"byte32 {enumName}'{tag.Name.ToString()}'{arrayIndex}{guidValue}", tag.Value);
    //    }

    //    public FPropertyTag GetNative(Transfer transfer)
    //    {
    //        return GetNative(transfer, Keys.First(), (UInt32)Values.First());
    //    }

    //    public static FPropertyTag GetNative(Transfer transfer, string key, UInt32 value)
    //    {
    //        var match = Regex.Match(key, Pattern);
    //        string enumName = match.Groups[1].Value;
    //        string name = match.Groups[2].Value;
    //        string index = match.Groups[3].Value;
    //        string guid = match.Groups[4].Value;
    //        return new FPropertyTag
    //        {
    //            Name = new FName(name, transfer),
    //            EnumName = enumName.Length > 0 ? new FName(enumName, transfer) : null,
    //            Type = new FName(FByteProperty.TYPE_NAME, transfer),
    //            Value = value,
    //            Size = 4,
    //            ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
    //            HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
    //            PropertyGuid = guid.Length > 0 ? new FGuid(guid) : default,
    //        };
    //    }
    //}
}

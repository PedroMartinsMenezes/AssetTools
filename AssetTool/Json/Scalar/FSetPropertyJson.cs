using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("set")]
    public class FSetPropertyJson : BasePropertyJson
    {
        public FSetPropertyJson() { }

        public override string Name => "set";
        public override string TypeName => FSetProperty.TYPE_NAME;

        public override string RebuildTypeNameKey(string key)
        {
            string a = $"{FSetProperty.TYPE_NAME} ";
            string b = key.GetNonNull("InnerType({0})", x => $"{x} ");
            string c = key.GetNonNull("StructName({0})", x => $"{x}");
            return $"{a}{b}{c}";
        }

        public override object FromNative(FPropertyTag tag, Transfer transfer = null)
        {
            return base.FromNative(tag, transfer);
        }

        public override string FromNativeFields(FPropertyTag tag)
        {
            FSetProperty prop = (FSetProperty)tag.Value;
            string a = $"Size({tag.Size}) ";
            string b = tag.InnerType is { } ? $"InnerType({tag.InnerType}) " : string.Empty;
            string c = tag.StructName is { } ? $"StructName({tag.StructName}) " : string.Empty;
            string d = prop.NumElementsToRemove > 0 ? $"NumElementsToRemove({prop.NumElementsToRemove}) " : string.Empty;
            return $"{a}{b}{c}{d}";
        }

        public override object FromNativeValue(object value)
        {
            FSetProperty prop = (FSetProperty)value;
            Dictionary<string, object> dict = new()
            {
                ["Values"] = prop.Values
            };
            if (prop.NumElementsToRemove > 0)
            {
                dict["ValuesToRemove"] = prop.ValuesToRemove;
            }
            return dict;
        }

        public override FPropertyTag ToNative(Transfer transfer, string key, object value)
        {
            Size = key.GetNonNull("Size({0})", x => int.Parse(x));
            InnerType = key.GetNonNull("InnerType({0})", x => x);
            StructName = key.GetNonNull("StructName({0})", x => x);
            var tag = base.ToNative(transfer, key, value);
            return tag;
        }

        public override object ToNativeValue(Transfer transfer, object value)
        {
            FSetProperty prop = new();
            Dictionary<string, object> dict = value.ToObject<Dictionary<string, object>>(transfer);
            prop.Values = dict["Values"].ToObject<List<object>>(transfer);
            prop.Num = prop.Values.Count;
            prop.ValuesToRemove = dict.ContainsKey("ValuesToRemove") ? dict["ValuesToRemove"].ToObject<List<object>>(transfer) : null;
            prop.NumElementsToRemove = prop.ValuesToRemove?.Count ?? 0;
            return prop;
        }
    }
}

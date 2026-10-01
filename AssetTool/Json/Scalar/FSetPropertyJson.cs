using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("set")]
    public class FSetPropertyJson : BasePropertyJson
    {
        public FSetPropertyJson() { }

        public override string Name => "set";
        public override string TypeName => FSetProperty.TYPE_NAME;

        public override string TypeNameFromNative(FPropertyTag tag) => $"{FSetProperty.TYPE_NAME} {tag.StructName}";

        public override string TypeNameFromKey(string key) => $"{FSetProperty.TYPE_NAME} {key.GetNonNull("StructName({0})", x => x)}";

        public override string ExtraFields(FPropertyTag tag)
        {
            FSetProperty prop = (FSetProperty)tag.Value;
            string a = $"Size({tag.Size}) ";
            string b = tag.InnerType is { } ? $"InnerType({tag.InnerType}) " : string.Empty;
            string c = prop.NumElementsToRemove > 0 ? $"NumElementsToRemove({prop.NumElementsToRemove}) " : string.Empty;
            return $"{a}{b}{c}";
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
            return base.ToNative(transfer, key, value);
        }

        public override object ToNativeValue(Transfer transfer, object value)
        {
            FSetProperty prop = new();
            Dictionary<string, object> dict = value.ToObject<Dictionary<string, object>>(transfer);
            prop.Values = dict["Values"].ToObject<List<object>>(transfer);
            prop.Num = prop.Values.Count;
            prop.ValuesToRemove = dict.ContainsKey("ValuesToRemove") ? dict["ValuesToRemove"].ToObject<List<object>>(transfer) : [];
            prop.NumElementsToRemove = prop.ValuesToRemove.Count;
            return prop;
        }
    }
}

using System.Diagnostics;

namespace AssetTool
{
    [DebuggerDisplay("map")]
    public class FMapPropertyJson : BasePropertyJson
    {
        public FMapPropertyJson() { }

        public override string Name => "map";
        public override string TypeName => FMapProperty.TYPE_NAME;

        public override string BuildTypeNameKey(FPropertyTag tag)
        {
            return $"{FMapProperty.TYPE_NAME} {tag.KeyType} : {tag.ValueType}";
        }

        public override string RebuildTypeNameKey(string key)
        {
            string a = $"{FMapProperty.TYPE_NAME}";
            string b = key.GetNonNull("KeyType({0})", x => x);
            string c = key.GetNonNull("ValueType({0})", x => x);
            return $"{a} {b} : {c}";
        }

        public override object FromNative(FPropertyTag tag, Transfer transfer = null)
        {
            return base.FromNative(tag, transfer);
        }

        public override string FromNativeFields(FPropertyTag tag)
        {
            FMapProperty prop = (FMapProperty)tag.Value;
            string a = $"Size({tag.Size}) ";
            string b = tag.InnerType is { } ? $"InnerType({tag.InnerType}) " : string.Empty;
            string c = tag.ValueType is { } ? $"ValueType({tag.ValueType}) " : string.Empty;
            string d = tag.KeyType is { } ? $"KeyType({tag.KeyType}) " : string.Empty;
            string e = prop.NumKeysToRemove > 0 ? $"NumKeysToRemove({prop.NumKeysToRemove}) " : string.Empty;
            return $"{a}{b}{c}{d}{e}";
        }

        public override object FromNativeValue(object value)
        {
            FMapProperty prop = (FMapProperty)value;
            Dictionary<string, object> dict = new()
            {
                ["KeyProp"] = prop.KeyProp,
                ["ValueProp"] = prop.ValueProp
            };
            if (prop.NumKeysToRemove > 0)
            {
                dict["KeysToRemove"] = prop.KeysToRemove;
            }
            return dict;
        }

        public override FPropertyTag ToNative(Transfer transfer, string key, object value)
        {
            Size = key.GetNonNull("Size({0})", x => int.Parse(x));
            InnerType = key.GetNonNull("InnerType({0})", x => x);
            var tag = base.ToNative(transfer, key, value);
            return tag;
        }

        public override object ToNativeValue(Transfer transfer, object value)
        {
            FMapProperty prop = new();
            Dictionary<string, object> dict = value.ToObject<Dictionary<string, object>>(transfer);
            prop.KeyProp = dict["KeyProp"].ToObject<List<object>>(transfer);
            prop.ValueProp = dict["ValueProp"].ToObject<List<object>>(transfer);
            prop.NumEntries = prop.KeyProp.Count;
            prop.KeysToRemove = dict.ContainsKey("KeysToRemove") ? dict["KeysToRemove"].ToObject<List<object>>(transfer) : null;
            prop.NumKeysToRemove = prop.KeysToRemove?.Count ?? 0;
            return prop;
        }
    }
}

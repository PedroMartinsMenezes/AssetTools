using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public class FNamePropertyJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "name '([\\w]+)' (?:(\\d+))?\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FNamePropertyJson() { }

        public FNamePropertyJson(FPropertyTag tag)
        {
            Add($"name '{tag.Name.Value}'", ((FName)tag.Value).ToString());
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), (string)Values.First());
        }

        public static FPropertyTag GetNative(string key, string value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FNameProperty.TYPE_NAME),
                Size = 8,
                Value = new FName(value),
            };
        }
    }

    //public class FNamePropertyJson : FPropertyTag
    //{
    //    public string PropName;
    //    public string PropValue;

    //    public FNamePropertyJson(string name, string value)
    //    {
    //        Name = new FName(name);
    //        Type = new FName(FNameProperty.TYPE_NAME);
    //        Size = 8;
    //        Value = new FName(value);
    //    }

    //    public FNamePropertyJson(FPropertyTag tag)
    //    {
    //        PropName = tag.Name.Value;
    //        PropValue = ((FName)tag.Value).ToString();

    //        Name = tag.Name;
    //        Type = tag.Type;
    //        Size = tag.Size;
    //        ArrayIndex = tag.ArrayIndex;
    //        HasPropertyGuid = tag.HasPropertyGuid;
    //        StructName = tag.StructName;
    //        StructGuid = tag.StructGuid;
    //        BoolVal = tag.BoolVal;
    //        EnumName = tag.EnumName;
    //        InnerType = tag.InnerType;
    //        ValueType = tag.ValueType;
    //        MaybeInnerTag = tag.MaybeInnerTag;
    //        Value = tag.Value;
    //    }

    //    public static FPropertyTag GetNative(string[] v)
    //    {
    //        string value = string.Join(' ', v.Skip(2));
    //        return new FPropertyTag { Name = new FName(v[1]), Type = new FName(FNameProperty.TYPE_NAME), Value = new FName(value), Size = 8 };
    //    }
    //}

    //public class FNamePropertyJsonJsonConverter : JsonConverter<FNamePropertyJson>
    //{
    //    public override FNamePropertyJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    //    {
    //        reader.Read();
    //        string name = reader.GetString().Split(' ')[1];
    //        reader.Read();
    //        string value = reader.GetString();
    //        reader.Read();
    //        var obj = new FNamePropertyJson(name, value);
    //        return obj;

    //    }
    //    public override void Write(Utf8JsonWriter writer, FNamePropertyJson value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStartObject();
    //        writer.WriteString("name", $"{value.PropName} {value.PropValue}");
    //        writer.WriteEndObject();
    //    }
    //}
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FGuidPropertyJson : FPropertyTag
    {
        public string PropName;
        public Guid PropValue;

        public FGuidPropertyJson(string name, Guid value)
        {
            Name = new FName(name);
            Type = new FName(FStructProperty.TYPE_NAME);
            StructName = new FName(Consts.Guid);
            Size = 16;
            Value = value;
        }

        public FGuidPropertyJson(FPropertyTag tag)
        {
            PropName = tag.Name.Value;
            PropValue = tag.Value is { } ? ((FGuid)tag.Value).Value : Guid.Empty;

            Name = tag.Name;
            Type = tag.Type;
            Size = tag.Size;
            ArrayIndex = tag.ArrayIndex;
            HasPropertyGuid = tag.HasPropertyGuid;
            StructName = tag.StructName;
            StructGuid = tag.StructGuid;
            BoolVal = tag.BoolVal;
            EnumName = tag.EnumName;
            InnerType = tag.InnerType;
            ValueType = tag.ValueType;
            MaybeInnerTag = tag.MaybeInnerTag;
            Value = tag.Value;
        }

        public static FPropertyTag GetNative(string[] v)
        {
            return new FPropertyTag { Name = new FName(v[1]), Type = new FName(FStructProperty.TYPE_NAME), Value = new FGuid(v[2]), Size = 16, StructName = new FName(Consts.Guid) };
        }
    }

    public class FGuidPropertyJsonJsonConverter : JsonConverter<FGuidPropertyJson>
    {
        public override FGuidPropertyJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Read();
            string name = reader.GetString().Split(' ')[1];
            reader.Read();
            Guid value = reader.GetGuid();
            reader.Read();
            var obj = new FGuidPropertyJson(name, value);
            return obj;

        }
        public override void Write(Utf8JsonWriter writer, FGuidPropertyJson value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("guid", $"{value.PropName} {value.PropValue}");
            writer.WriteEndObject();
        }
    }
}

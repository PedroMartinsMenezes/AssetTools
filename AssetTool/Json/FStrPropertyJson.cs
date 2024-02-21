using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FStrPropertyJson : FPropertyTag
    {
        public string PropName;
        public string PropValue;

        public FStrPropertyJson(string name, string value)
        {
            Name = new FName(name);
            Type = new FName(FIntProperty.TYPE_NAME);
            Size = value.SerializedSize();
            Value = new FString(value);
        }

        public FStrPropertyJson(FPropertyTag tag)
        {
            PropName = tag.Name.Value;
            PropValue = ((FString)tag.Value).Value;

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
    }

    public class FStrPropertyJsonJsonConverter : JsonConverter<FStrPropertyJson>
    {
        public override FStrPropertyJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Read();
            string name = reader.GetString().Split(' ')[1];
            reader.Read();
            string value = reader.GetString();
            reader.Read();
            var obj = new FStrPropertyJson(name, value);
            return obj;

        }
        public override void Write(Utf8JsonWriter writer, FStrPropertyJson value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("string", $"{value.PropName} {value.PropValue}");
            writer.WriteEndObject();
        }
    }
}

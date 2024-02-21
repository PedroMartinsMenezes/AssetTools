using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FFloatPropertyJson : FPropertyTag
    {
        public string PropName;
        public float PropValue;

        public FFloatPropertyJson(string name, float value)
        {
            Name = new FName(name);
            Type = new FName(FFloatProperty.TYPE_NAME);
            Size = 4;
            Value = value;
        }

        public FFloatPropertyJson(FPropertyTag tag)
        {
            PropName = tag.Name.Value;
            PropValue = (float)tag.Value;

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

    public class FFloatPropertyJsonJsonConverter : JsonConverter<FFloatPropertyJson>
    {
        public override FFloatPropertyJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Read();
            string name = reader.GetString().Split(' ')[1];
            reader.Read();
            float value = reader.GetSingle();
            reader.Read();
            var obj = new FFloatPropertyJson(name, value);
            return obj;

        }
        public override void Write(Utf8JsonWriter writer, FFloatPropertyJson value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("float", $"{value.PropName} {value.PropValue}");
            writer.WriteEndObject();
        }
    }
}

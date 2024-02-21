using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class SoftObjectPropertyJson : FPropertyTag
    {
        public string PropName;
        public UInt32 PropValue;

        public SoftObjectPropertyJson(string name, UInt32 value)
        {
            Name = new FName(name);
            Type = new FName(Consts.SoftObjectProperty);
            Size = 4;
            Value = value;
        }

        public SoftObjectPropertyJson(FPropertyTag tag)
        {
            PropName = tag.Name.Value;
            PropValue = (UInt32)tag.Value;

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

    public class SoftObjectPropertyJsonJsonConverter : JsonConverter<SoftObjectPropertyJson>
    {
        public override SoftObjectPropertyJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Read();
            string name = reader.GetString().Split(' ')[1];
            reader.Read();
            UInt32 value = reader.GetUInt32();
            reader.Read();
            var obj = new SoftObjectPropertyJson(name, value);
            return obj;

        }
        public override void Write(Utf8JsonWriter writer, SoftObjectPropertyJson value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("soft", $"{value.PropName} {value.PropValue}");
            writer.WriteEndObject();
        }
    }
}

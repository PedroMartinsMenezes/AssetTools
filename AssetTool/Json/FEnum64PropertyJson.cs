using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FEnum64PropertyJson : FPropertyTag
    {
        public string PropName;
        public UInt64 PropValue;
        public string PropEnumName;

        public FEnum64PropertyJson(string name, UInt64 value, string enumName)
        {
            Name = new FName(name);
            Type = new FName(FEnumProperty.TYPE_NAME);
            Size = 4;
            Value = value;
            EnumName = new FName(enumName);
        }

        public FEnum64PropertyJson(FPropertyTag tag)
        {
            PropName = tag.Name.Value;
            PropValue = (UInt64)tag.Value;
            PropEnumName = tag.EnumName.Value;

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

    public class FEnum64PropertyJsonJsonConverter : JsonConverter<FEnum64PropertyJson>
    {
        public override FEnum64PropertyJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Read();
            (string enumName, string name) = reader.GetString().Split(' ') is var v ? (v[0], v[1]) : (null, null);
            reader.Read();
            UInt64 value = reader.GetUInt64();
            reader.Read();
            var obj = new FEnum64PropertyJson(name, value, enumName);
            return obj;

        }
        public override void Write(Utf8JsonWriter writer, FEnum64PropertyJson value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("enum64", $"{value.PropEnumName} {value.PropName} {value.PropValue}");
            writer.WriteEndObject();
        }
    }
}

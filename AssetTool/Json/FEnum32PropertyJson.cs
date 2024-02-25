using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [Description("Not Used")]
    public class FEnum32PropertyJson : FPropertyTag
    {
        public string PropName;
        public UInt32 PropValue;
        public string PropEnumName;

        public FEnum32PropertyJson(string name, UInt32 value, string enumName)
        {
            Name = new FName(name);
            Type = new FName(FEnumProperty.TYPE_NAME);
            Size = 4;
            Value = value;
            EnumName = new FName(enumName);
        }

        public FEnum32PropertyJson(FPropertyTag tag)
        {
            PropName = tag.Name.Value;
            PropValue = (UInt32)tag.Value;
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

    public class FEnum32PropertyJsonJsonConverter : JsonConverter<FEnum32PropertyJson>
    {
        public override FEnum32PropertyJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Read();
            (string enumName, string name) = reader.GetString().Split(' ') is var v ? (v[0], v[1]) : (null, null);
            reader.Read();
            UInt32 value = reader.GetUInt32();
            reader.Read();
            var obj = new FEnum32PropertyJson(name, value, enumName);
            return obj;

        }
        public override void Write(Utf8JsonWriter writer, FEnum32PropertyJson value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("enum32", $"{value.PropEnumName} {value.PropName} {value.PropValue}");
            writer.WriteEndObject();
        }
    }
}

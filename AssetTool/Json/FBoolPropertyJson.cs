using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FBoolPropertyJson : FPropertyTag
    {
        public string PropName;
        public bool PropValue;

        public FBoolPropertyJson(string name, bool value)
        {
            Name = new FName(name);
            Type = new FName(FBoolProperty.TYPE_NAME);
            BoolVal = (byte)(value ? 1 : 0);
        }

        public FBoolPropertyJson(FPropertyTag tag)
        {
            PropName = tag.Name.Value;
            PropValue = tag.BoolVal == 1;

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

    public class FBoolPropertyJsonJsonConverter : JsonConverter<FBoolPropertyJson>
    {
        public override FBoolPropertyJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Read();
            string name = reader.GetString().Split(' ')[1];
            reader.Read();
            bool value = reader.GetBoolean();
            reader.Read();
            var obj = new FBoolPropertyJson(name, value);
            return obj;

        }
        public override void Write(Utf8JsonWriter writer, FBoolPropertyJson value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("bool", $"{value.PropName} {value.PropValue}");
            writer.WriteEndObject();
        }
    }
}

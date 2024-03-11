using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FIntPropertyJson : FPropertyTag
    {
        public string PropName;
        public Int32 PropValue;

        public FIntPropertyJson(string name, Int32 value)
        {
            Name = new FName(name);
            Type = new FName(FIntProperty.TYPE_NAME);
            Size = 4;
            Value = value;
        }

        public FIntPropertyJson(FPropertyTag tag)
        {
            PropName = tag.Name.Value;
            PropValue = (Int32)tag.Value;

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
            return new FPropertyTag { Name = new FName(v[1]), Type = new FName(FIntProperty.TYPE_NAME), Value = Int32.Parse(v[2]), Size = 4 };
        }
    }

    public class FIntPropertyJsonJsonConverter : JsonConverter<FIntPropertyJson>
    {
        public override FIntPropertyJson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            reader.Read();
            string name = reader.GetString().Split(' ')[1];
            reader.Read();
            Int32 value = reader.GetInt32();
            reader.Read();
            var obj = new FIntPropertyJson(name, value);
            return obj;

        }
        public override void Write(Utf8JsonWriter writer, FIntPropertyJson value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("int", $"{value.PropName} {value.PropValue}");
            writer.WriteEndObject();
        }
    }
}

using System.Text.Json;

namespace AssetTool
{
    public class FBoolProperty : FProperty
    {
        public new const string TYPE_NAME = "BoolProperty";
        public override string TypeName => TYPE_NAME;

        public byte FieldSize;
        public byte ByteOffset;
        public byte ByteMask;
        public byte FieldMask;
        public byte BoolSize;
        public byte NativeBool;

        [Location("void FBoolProperty::Serialize( FArchive& Ar )")]
        public override FField Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref FieldSize);
            transfer.Move(ref ByteOffset);
            transfer.Move(ref ByteMask);
            transfer.Move(ref FieldMask);
            transfer.Move(ref BoolSize);
            transfer.Move(ref NativeBool);
            return this;
        }

        public static byte MoveValue(Transfer transfer, byte value)
        {
            transfer.Move(ref value);
            return value;
        }
    }

    public class FBoolPropertySerializer : FPropertySerializerBase<FBoolProperty>
    {
        public FBoolProperty Read(JsonElement root, JsonSerializerOptions options)
        {
            string key = root.EnumerateObject().First().Name;

            JsonElement value = root.EnumerateObject().First().Value;

            var obj = ReadKeyValue(key, value);

            obj.ElementSize = 1;

            obj.FieldSize = key.GetNonNull("FieldSize({0})", x => byte.Parse(x), (byte)1);
            obj.ByteOffset = key.GetNonNull("ByteOffset({0})", x => byte.Parse(x), (byte)0);
            obj.ByteMask = key.GetNonNull("ByteMask({0})", x => byte.Parse(x), (byte)1);
            obj.FieldMask = key.GetNonNull("FieldMask({0})", x => byte.Parse(x), (byte)255);
            obj.BoolSize = key.GetNonNull("BoolSize({0})", x => byte.Parse(x), (byte)1);
            obj.NativeBool = key.GetNonNull("NativeBool({0})", x => byte.Parse(x), (byte)1);

            return obj;
        }

        public void Write(Utf8JsonWriter writer, FBoolProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            Dictionary<string, object> inlineFields = new();

            if (value.FieldSize != 1) inlineFields.Add("FieldSize", value.FieldSize);
            if (value.ByteOffset != 0) inlineFields.Add("ByteOffset", value.ByteOffset);
            if (value.ByteMask != 1) inlineFields.Add("ByteMask", value.ByteMask);
            if (value.FieldMask != 255) inlineFields.Add("FieldMask", value.FieldMask);
            if (value.BoolSize != 1) inlineFields.Add("BoolSize", value.BoolSize);
            if (value.NativeBool != 1) inlineFields.Add("NativeBool", value.NativeBool);

            WriteKeyValue(writer, options, value, "prop-bool", inlineFields);

            writer.WriteEndObject();
        }
    }
}

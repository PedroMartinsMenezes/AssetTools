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

        public override FProperty Read(JsonProperty elem, JsonSerializerOptions options)
        {
            string key = elem.Name;

            JsonElement value = elem.Value;

            var obj = ReadKeyValue<FBoolProperty>(key, value);

            obj.ElementSize = 1;

            obj.FieldSize = key.GetNonNull("FieldSize({0})", x => byte.Parse(x), (byte)1);
            obj.ByteOffset = key.GetNonNull("ByteOffset({0})", x => byte.Parse(x), (byte)0);
            obj.ByteMask = key.GetNonNull("ByteMask({0})", x => byte.Parse(x), (byte)1);
            obj.FieldMask = key.GetNonNull("FieldMask({0})", x => byte.Parse(x), (byte)255);
            obj.BoolSize = key.GetNonNull("BoolSize({0})", x => byte.Parse(x), (byte)1);
            obj.NativeBool = key.GetNonNull("NativeBool({0})", x => byte.Parse(x), (byte)1);

            return obj;
        }

        public override void Write(Utf8JsonWriter writer, JsonSerializerOptions options)
        {
            Dictionary<string, object> inlineFields = new();

            if (this.FieldSize != 1) inlineFields.Add("FieldSize", this.FieldSize);
            if (this.ByteOffset != 0) inlineFields.Add("ByteOffset", this.ByteOffset);
            if (this.ByteMask != 1) inlineFields.Add("ByteMask", this.ByteMask);
            if (this.FieldMask != 255) inlineFields.Add("FieldMask", this.FieldMask);
            if (this.BoolSize != 1) inlineFields.Add("BoolSize", this.BoolSize);
            if (this.NativeBool != 1) inlineFields.Add("NativeBool", this.NativeBool);

            WriteKeyValue(writer, options, this, "prop-bool", inlineFields);
        }
    }
}

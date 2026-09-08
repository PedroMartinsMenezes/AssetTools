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
            var obj = ReadBaseProperties(root);
            obj.ElementSize = 1;
            obj.FieldSize = 1;
            obj.ByteOffset = 0;
            obj.ByteMask = 1;
            obj.FieldMask = 255;
            obj.BoolSize = 1;
            obj.NativeBool = 1;

            if (root.TryGetProperty("FieldSize", out var fieldSize)) obj.FieldSize = fieldSize.GetByte();
            if (root.TryGetProperty("ByteOffset", out var byteOffset)) obj.ByteOffset = byteOffset.GetByte();
            if (root.TryGetProperty("ByteMask", out var byteMask)) obj.ByteMask = byteMask.GetByte();
            if (root.TryGetProperty("FieldMask", out var fieldMask)) obj.FieldMask = fieldMask.GetByte();
            if (root.TryGetProperty("BoolSize", out var boolSize)) obj.BoolSize = boolSize.GetByte();
            if (root.TryGetProperty("NativeBool", out var nativeBool)) obj.NativeBool = nativeBool.GetByte();
            return obj;
        }

        public void Write(Utf8JsonWriter writer, FBoolProperty value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            WriteBaseProperties(writer, value);

            if (value.FieldSize != 1) writer.WriteNumber("FieldSize", value.FieldSize);
            if (value.ByteOffset != 0) writer.WriteNumber("ByteOffset", value.ByteOffset);
            if (value.ByteMask != 1) writer.WriteNumber("ByteMask", value.ByteMask);
            if (value.FieldMask != 255) writer.WriteNumber("FieldMask", value.FieldMask);
            if (value.BoolSize != 1) writer.WriteNumber("BoolSize", value.BoolSize);
            if (value.NativeBool != 1) writer.WriteNumber("NativeBool", value.NativeBool);

            writer.WriteEndObject();
        }
    }
}

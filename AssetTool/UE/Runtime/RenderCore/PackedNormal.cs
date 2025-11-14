using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    #region FDeprecatedSerializedPackedNormal
    public struct FDeprecatedSerializedPackedNormal : ITransferable
    {
        public UInt32 Packed;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Packed);
            return this;
        }
    }

    public class FDeprecatedSerializedPackedNormalJsonConverter : JsonConverter<FDeprecatedSerializedPackedNormal>
    {
        public override FDeprecatedSerializedPackedNormal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FDeprecatedSerializedPackedNormal { Packed = reader.GetUInt32() };
        }

        public override void Write(Utf8JsonWriter writer, FDeprecatedSerializedPackedNormal value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Packed);
        }
    }
    #endregion

    #region FPackedNormal
    public struct FPackedNormal : ITransferable
    {
        public int8 X, Y, Z, W;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            transfer.Move(ref W);
            return this;
        }

        public override string ToString() => $"{X} {Y} {Z} {W}";
    }

    public class FPackedNormalJsonConverter : JsonConverter<FPackedNormal>
    {
        public override FPackedNormal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var v = reader.GetString().ToSByteArray();
            return new FPackedNormal { X = v[0], Y = v[1], Z = v[2], W = v[3] };
        }

        public override void Write(Utf8JsonWriter writer, FPackedNormal value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
    #endregion
}

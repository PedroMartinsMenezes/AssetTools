using System.ComponentModel;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("R{R} G{G} B{B}")]
    public class FSHVectorRGB : ITransferable<int>
    {
        public FSHVector R = new();
        public FSHVector G = new();
        public FSHVector B = new();

        [Location("friend FArchive& operator<<(FArchive& Ar, TSHVectorRGB& SH)")]
        public ITransferable Move(Transfer transfer, int order)
        {
            R.Move(transfer, order);
            G.Move(transfer, order);
            B.Move(transfer, order);
            return this;
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FSHVectorRGBJsonConverter : JsonConverter<FSHVectorRGB>
    {
        public override FSHVectorRGB Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var parts = reader.GetString().Split(" | ");
            return new FSHVectorRGB { R = new FSHVector { v = parts[0].ToFloatArray() }, G = new FSHVector { v = parts[1].ToFloatArray() }, B = new FSHVector { v = parts[2].ToFloatArray() } };
        }
        public override void Write(Utf8JsonWriter writer, FSHVectorRGB value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"{string.Join(' ', value.R.v)} | {string.Join(' ', value.G.v)} | {string.Join(' ', value.B.v)}");
        }
    }

    [Description("A vector of spherical harmonic coefficients.")]
    [DebuggerDisplay("({string.Join(' ', v)})")]
    public class FSHVector : ITransferable<int>
    {
        public float[] v;

        [Location("friend FArchive& operator<<(FArchive& Ar, TSHVector& SH)")]
        public ITransferable Move(Transfer transfer, int order)
        {
            int count = GetNumComponents(order);
            transfer.Move(ref v, count);
            return this;
        }

        private static int GetNumComponents(int order)
        {
            if (order == 2)
            {
                int MaxSHOrder = order;
                int MaxSHBasis = MaxSHOrder * MaxSHOrder;
                int NumComponentsPerSIMDVector = 4;
                int NumSIMDVectors = (MaxSHBasis + NumComponentsPerSIMDVector - 1) / NumComponentsPerSIMDVector;
                int NumTotalFloats = NumSIMDVectors * NumComponentsPerSIMDVector;
                return NumTotalFloats;
            }
            else if (order == 3)
            {
                int MaxSHOrder = order;
                int MaxSHBasis = MaxSHOrder * MaxSHOrder;
                return MaxSHBasis;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public ITransferable Move(Transfer transfer)
        {
            throw new NotImplementedException();
        }
    }

    public class FSHVectorJsonConverter : JsonConverter<FSHVector>
    {
        public override FSHVector Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FSHVector { v = reader.GetString().ToFloatArray() };
        }
        public override void Write(Utf8JsonWriter writer, FSHVector value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(' ', value.v));
        }
    }
}

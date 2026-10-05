using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool.Chaos
{
    [DebuggerDisplay("({MPlaneConcrete.MX.X} {MPlaneConcrete.MX.Y} {MPlaneConcrete.MX.Z}) ({MPlaneConcrete.MNormal.X} {MPlaneConcrete.MNormal.Y} {MPlaneConcrete.MNormal.Z})")]
    public class TPlane3 : FImplicitObject
    {
        public TPlaneConcrete MPlaneConcrete;

        [Location("FORCEINLINE void SerializeImp(FArchive& Ar) at 322")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref MPlaneConcrete);
            return this;
        }
    }

    [DebuggerDisplay("({MX.X} {MX.Y} {MX.Z}) ({MNormal.X} {MNormal.Y} {MNormal.Z})")]
    public class TPlaneConcrete : ITransferable
    {
        public TVec3 MX;
        public TVec3 MNormal;

        [Location("FORCEINLINE void Serialize(FArchive& Ar) at 230")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref MX);
            transfer.Move(ref MNormal);
            return this;
        }
    }

    public class TPlaneConcreteJsonConverter : JsonConverter<List<TPlaneConcrete>>
    {
        public override List<TPlaneConcrete> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string s = reader.GetString();
            return s.Length == 0 ? [] : s.Split(" | ").Select(x =>
            {
                var parts = x.Split(' ');
                return new TPlaneConcrete()
                {
                    MX = new TVec3() { X = float.Parse(parts[0]), Y = float.Parse(parts[1]), Z = float.Parse(parts[2]) },
                    MNormal = new TVec3() { X = float.Parse(parts[3]), Y = float.Parse(parts[4]), Z = float.Parse(parts[5]) }
                };
            }).ToList();
        }
        public override void Write(Utf8JsonWriter writer, List<TPlaneConcrete> value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Join(" | ", value.Select(x => $"{x.MX.X} {x.MX.Y} {x.MX.Z} {x.MNormal.X} {x.MNormal.Y} {x.MNormal.Z}")));
        }
    }
}

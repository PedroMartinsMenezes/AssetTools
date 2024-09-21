using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [Location("FArchive& operator<<(FArchive& Ar, FNameEntrySerialized& E)")]
    public class FNameEntrySerialized
    {
        public FString Name = new();
        public UInt16[] DummyHashes = [0, 0];

        [Location("FLinkerLoad::ELinkerStatus FLinkerLoad::SerializeNameMap()")]
        public FNameEntrySerialized Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            if (Supports.UEVer(EUnrealEngineObjectUE4Version.VER_UE4_NAME_HASHES_SERIALIZED))
            {
                transfer.Move(ref DummyHashes[0]);
                transfer.Move(ref DummyHashes[1]);
            }
            return this;
        }
    }

    public class FNameEntrySerializedJsonConverter : JsonConverter<FNameEntrySerialized>
    {
        public override FNameEntrySerialized Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var input = reader.GetString()!;
            var m = Regex.Match(input, @"\((\d+) (\d+)\) (.*)");
            ushort num1 = ushort.Parse(m.Groups[1].Value);
            ushort num2 = ushort.Parse(m.Groups[2].Value);
            string name = m.Groups[3].Value;

            return new FNameEntrySerialized { Name = new FString(name), DummyHashes = [num1, num2] };
        }

        public override void Write(Utf8JsonWriter writer, FNameEntrySerialized value, JsonSerializerOptions options)
        {
            writer.WriteStringValue($"({value.DummyHashes[0]} {value.DummyHashes[1]}) {value.Name.Value}");
        }
    }
}

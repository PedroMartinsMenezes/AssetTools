using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    [DebuggerDisplay("Count = {NameCount}")]
    public class NameMap : ITransferible
    {
        public int NameCount;
        public List<FNameEntrySerialized> NameEntries;
        [JsonIgnore] public bool IncompleteDeserialization;

        public NameMap() { }

        public NameMap(int nameCount)
        {
            NameCount = nameCount;
        }

        [Location("FLinkerLoad::ELinkerStatus FLinkerLoad::SerializeNameMap()")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref NameEntries, NameCount);
            return this;
        }
    }

    public class NameMapJsonConverter : JsonConverter<NameMap>
    {
        public override NameMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<FNameEntrySerialized> NameEntries = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    string text = reader.GetString();
                    if (Regex.Match(text, @"\((\d+) (\d+)\)") is Match m && m.Success)
                    {
                        FNameEntrySerialized item = new()
                        {
                            DummyHashes = [ushort.Parse(m.Groups[1].Value), ushort.Parse(m.Groups[2].Value)],
                            Name = new FString(Regex.Replace(text, @"\(\d+ \d+\) ", "")),
                        };
                        NameEntries.Add(item);
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
            NameMap obj = new(NameEntries.Count) { NameEntries = NameEntries, IncompleteDeserialization = true };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, NameMap value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            value.NameEntries.ForEach(x => writer.WriteStringValue($"({x.DummyHashes[0]} {x.DummyHashes[1]}) {x.Name.Value}"));
            writer.WriteEndArray();
        }
    }
}

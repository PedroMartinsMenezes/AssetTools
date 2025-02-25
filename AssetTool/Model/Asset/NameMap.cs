﻿using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public class NameMap : Transferible<NameMap>
    {
        private readonly FPackageFileSummary PackageFileSummary;
        public List<FNameEntrySerialized> NameEntries = [];

        public NameMap(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        [Location("FLinkerLoad::ELinkerStatus FLinkerLoad::SerializeNameMap()")]
        public override ITransferible Move(Transfer transfer)
        {
            NameEntries.Resize(transfer, PackageFileSummary.NameCount);
            NameEntries.ForEach(x => x.Move(transfer));
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
            var summary = new FPackageFileSummary { NameCount = NameEntries.Count };
            NameMap obj = new(summary) { NameEntries = NameEntries };
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

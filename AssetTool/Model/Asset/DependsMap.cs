using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class DependsMap : ITransferible<DependsMap>
    {
        public List<PackageIndexes> Map = [];

        public override void Move(Transfer transfer, int count = 0)
        {
            Map.Resize(transfer, count);
            Map.ForEach(x => x.Move(transfer));
        }

        public class PackageIndexes
        {
            public List<FPackageIndex> Indices = [];

            public void Move(Transfer transfer)
            {
                Indices.Resize(transfer);
                Indices.ForEach(x => x.Move(transfer));
            }
        }
    }

    public class DependsMapJsonConverter : JsonConverter<DependsMap>
    {
        public override DependsMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            DependsMap obj = new() { Map = new() };
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    string indices = reader.GetString();
                    DependsMap.PackageIndexes item = new() { Indices = indices == string.Empty ? [] : indices.Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList() };
                    obj.Map.Add(item);
                }
            }
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, DependsMap value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            value.Map.ForEach(x => writer.WriteStringValue(string.Join(' ', x.Indices.Select(y => y.Index.ToString()))));
            writer.WriteEndArray();
        }
    }
}

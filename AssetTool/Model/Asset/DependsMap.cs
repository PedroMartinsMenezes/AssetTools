using System.Text.Json;
using System.Text.Json.Serialization;
using static AssetTool.DependsMap;

namespace AssetTool
{
    public class DependsMap : ITransferable
    {
        public int ExportCount;
        public List<PackageIndexes> Map;

        public DependsMap() { }

        public DependsMap(int exportCount)
        {
            ExportCount = exportCount;
        }

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Map, ExportCount);
            return this;
        }

        public class PackageIndexes : ITransferable
        {
            public List<FPackageIndex> Indices;

            public ITransferable Move(Transfer transfer)
            {
                transfer.Move(ref Indices);
                return this;
            }
        }
    }

    public class DependsMapJsonConverter : JsonConverter<DependsMap>
    {
        public override DependsMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            List<PackageIndexes> Map = [];
            if (reader.TokenType == JsonTokenType.StartArray)
            {
                while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                {
                    string indices = reader.GetString();
                    List<FPackageIndex> list = indices == string.Empty ? [] : indices.Split(' ').Select(x => new FPackageIndex { Index = int.Parse(x) }).ToList();
                    Map.Add(new PackageIndexes { Indices = list });
                }
            }
            DependsMap obj = new(Map.Count) { Map = Map };
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

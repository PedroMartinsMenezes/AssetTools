using System.Text.Json;
using System.Text.Json.Serialization;
using static AssetTool.DependsMap;

namespace AssetTool
{
    public class DependsMap : Transferible<DependsMap>
    {
        private readonly FPackageFileSummary PackageFileSummary;
        public List<PackageIndexes> Map = [];

        public DependsMap(FPackageFileSummary PackageFileSummary)
        {
            this.PackageFileSummary = PackageFileSummary;
        }

        public override ITransferible Move(Transfer transfer)
        {
            Map.Resize(transfer, PackageFileSummary.ExportCount);
            Map.ForEach(x => x.Move(transfer));
            return this;
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
            var summary = new FPackageFileSummary { ExportCount = Map.Count };
            DependsMap obj = new(summary) { Map = Map };
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

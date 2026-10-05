using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class ExportMap : ITransferable
    {
        public int ExportCount;
        public List<FObjectExport> ObjectExports;
        public ExportMapPreloadDependencies PreloadDependencies;

        public FObjectExport this[int index]
        {
            get => ObjectExports[index];
            set => ObjectExports[index] = value;
        }

        public int Count => ObjectExports?.Count ?? 0;

        public long EndOffset => (ObjectExports?[^1].SerialOffset ?? 0) + (ObjectExports[^1].SerialSize);

        public ExportMap() { }

        public ExportMap(int exportCount)
        {
            ExportCount = exportCount;
        }

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref ObjectExports, ExportCount);
            ObjectExports.ForEach(x => x.UpdateIndexes(transfer));
            return this;
        }
    }

    public class ExportMapPreloadDependencies : ITransferable
    {
        public List<FObjectExport> ObjectExports;

        public ExportMapPreloadDependencies(List<FObjectExport> objectExports)
        {
            ObjectExports = objectExports;
        }

        public ITransferable Move(Transfer transfer)
        {
            if (transfer.Supports.VER_UE4_PRELOAD_DEPENDENCIES_IN_COOKED_EXPORTS)
            {
                ObjectExports.ForEach(x => x.PreloadDependencies.Move(transfer));
            }
            return this;
        }
    }

    public class ExportMapJsonConverter : JsonConverter<ExportMap>
    {
        public override ExportMap Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var list = jsonDoc.Deserialize<List<FObjectExport>>(options);
            ExportMap obj = new(list.Count) { ObjectExports = list };
            return obj;
        }

        public override void Write(Utf8JsonWriter writer, ExportMap value, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.Parse(value.ObjectExports.ToJson());
            jsonDoc.RootElement.WriteTo(writer);
        }
    }
}

using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("[{Index}] ImportIndex[{ImportIndex}] {TypeName}")]
    public class FPackageIndex : ITransferible
    {
        public const int SIZE = 4;

        public Int32 Index;

        [JsonIgnore] public int ExportIndex;
        [JsonIgnore] public int ImportIndex;
        [JsonIgnore] public string TypeName;

        public FPackageIndex() { }

        public FPackageIndex(int index)
        {
            Index = index;
            if (Index < 0)
                ImportIndex = Index;
            else if (Index > 0)
                ExportIndex = Index;
        }

        public FPackageIndex(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (value.Contains(':'))
                {
                    string token = "ExportIndex[";
                    if (value.Contains(token))
                    {
                        int a = value.IndexOf(token) + token.Length;
                        int b = value.IndexOf(']', a);
                        ExportIndex = int.Parse(value[a..b]);
                    }
                    token = "ImportIndex[";
                    if (value.Contains(token))
                    {
                        int a = value.IndexOf(token) + token.Length;
                        int b = value.IndexOf(']', a);
                        ImportIndex = int.Parse(value[a..b]);
                    }
                    Index = ExportIndex != 0 ? ExportIndex : ImportIndex;
                }
                else
                {
                    Index = int.Parse(value);
                    if (Index < 0)
                        ImportIndex = Index;
                    else if (Index > 0)
                        ExportIndex = Index;
                }
            }
        }

        public ITransferible Move(Transfer transfer)
        {
            return Move(transfer, false);
        }

        public ITransferible Move(Transfer transfer, bool ignore)
        {
            transfer.Move(ref Index);
            if (!ignore && transfer.IsReading)
            {
                UpdateIndexes(transfer);
            }
            return this;
        }

        public void UpdateIndexes(Transfer transfer)
        {
            (ExportIndex, ImportIndex, TypeName) = transfer.GlobalObjects.GetTypeNameFromPackageIndex(Index);
        }

        public override string ToString() => Index.ToString();
        public bool IsImport() => Index < 0;
        public bool IsExport() => Index > 0;
    }

    public class FPackageIndexJsonConverter : JsonConverter<FPackageIndex>
    {
        public override FPackageIndex Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (string.IsNullOrEmpty(value))
            {
                return new FPackageIndex();
            }
            else if (value.Contains(':'))
            {
                int ExportIndex = 0;
                int ImportIndex = 0;
                string token = "ExportIndex[";
                if (value.Contains(token))
                {
                    int a = value.IndexOf(token) + token.Length;
                    int b = value.IndexOf(']', a);
                    ExportIndex = int.Parse(value[a..b]);
                }
                token = "ImportIndex[";
                if (value.Contains(token))
                {
                    int a = value.IndexOf(token) + token.Length;
                    int b = value.IndexOf(']', a);
                    ImportIndex = int.Parse(value[a..b]);
                }
                int Index = ExportIndex != 0 ? ExportIndex : ImportIndex;
                return new FPackageIndex { Index = Index };
            }
            else
            {
                return new FPackageIndex { Index = int.Parse(value) };
            }
        }
        public override FPackageIndex ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void Write(Utf8JsonWriter writer, FPackageIndex value, JsonSerializerOptions options)
        {
            if (value.Index == 0)
                writer.WriteStringValue("");
            else if (value.ExportIndex != 0)
                writer.WriteStringValue($"ExportIndex[{value.ExportIndex}] ImportIndex[{value.ImportIndex}]: {value.TypeName}");
            else
                writer.WriteStringValue($"ImportIndex[{value.ImportIndex}]: {value.TypeName}");

        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FPackageIndex value, JsonSerializerOptions options)
        {
            if (value.Index == 0)
                writer.WritePropertyName("");
            else if (value.ExportIndex != 0)
                writer.WritePropertyName($"ExportIndex[{value.ExportIndex}] ImportIndex[{value.ImportIndex}]: {value.TypeName}");
            else
                writer.WritePropertyName($"ImportIndex[{value.ImportIndex}]: {value.TypeName}");
        }
    }

    public static class FPackageIndexExt
    {
        public static string ToStr(this List<FPackageIndex> self)
        {
            return self == default ? string.Empty : string.Join(' ', self.Select(x => x.Index).ToArray());
        }
    }
}

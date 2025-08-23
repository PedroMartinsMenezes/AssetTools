using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Index}")]
    public class FPackageIndex : ITransferible
    {
        public const int SIZE = 4;

        public Int32 Index;
        public string Name;

        public FPackageIndex() { }

        public FPackageIndex(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (value.Contains('['))
                {
                    (int a, int b) = (value.IndexOf('[') + 1, value.IndexOf(']'));
                    Index = int.Parse(value[a..b]);
                    Name = value[(b + 2)..];
                }
                else
                {
                    Index = int.Parse(value);
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
                Name = transfer.GlobalObjects.GetExportOrImportName(Index);
            }
            return this;
        }

        public override string ToString() => Index.ToString();
        public bool IsImport() => Index < 0;
        public bool IsExport() => Index > 0;
    }

    public class FPackageIndexJsonConverter : JsonConverter<FPackageIndex>
    {
        public override FPackageIndex Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            if (string.IsNullOrEmpty(s))
            {
                return new FPackageIndex();
            }
            else if (s.Contains('['))
            {
                (int a, int b) = (s.IndexOf('[') + 1, s.IndexOf(']'));
                int index = int.Parse(s[a..b]);
                string name = s[(b + 2)..];
                return new FPackageIndex { Index = index, Name = name };
            }
            else
            {
                return new FPackageIndex { Index = int.Parse(s) };
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
            else if (value.Name == null)
                writer.WriteStringValue(value.Index.ToString());
            else if (value.Index < 0)
                writer.WriteStringValue($"ImportIndex[{value.Index}] {value.Name}");
            else
                writer.WriteStringValue($"ExportIndex[{value.Index}] {value.Name}");
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FPackageIndex value, JsonSerializerOptions options)
        {
            if (value.Index == 0)
                writer.WritePropertyName("");
            else if (value.Name == null)
                writer.WritePropertyName(value.Index.ToString());
            else if (value.Index < 0)
                writer.WritePropertyName($"ImportIndex[{value.Index}] {value.Name}");
            else
                writer.WritePropertyName($"ExportIndex[{value.Index}] {value.Name}");
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

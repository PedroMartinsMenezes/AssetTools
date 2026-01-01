using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [DebuggerDisplay("{Index}")]
    public class FObjectPtr : ITransferable
    {
        public FPackageIndex Index;

        [JsonIgnore] public string TypeName => Index.TypeName;

        [Location("FArchive& FLinkerLoad::operator<<(FObjectPtr& ObjectPtr)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            return this;
        }

        public override string ToString()
        {
            return $"ImportIndex[{Index.Index}] {TypeName}";
        }

        public static FObjectPtr FromString(string s)
        {
            if (s.Contains('['))
            {
                string index = s[(s.IndexOf('[') + 1)..s.IndexOf(']')];
                string typeName = index == "0" ? null : s[(s.IndexOf(' ') + 1)..];
                return new FObjectPtr { Index = new() { Index = int.Parse(index), TypeName = typeName } };
            }
            else
            {
                return new FObjectPtr { Index = new(int.Parse(s)) };
            }
        }
    }

    public class FObjectPtrJsonConverter : JsonConverter<FObjectPtr>
    {
        public override FObjectPtr Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return FObjectPtr.FromString(reader.GetString());
        }
        public override void Write(Utf8JsonWriter writer, FObjectPtr value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
        public override FObjectPtr ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Read(ref reader, typeToConvert, options);
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FObjectPtr value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.ToString());
        }
    }

    [DebuggerDisplay("{Index}")]
    public class TObjectPtr<T> : ITransferable where T : new()
    {
        public FPackageIndex Index;
        public T Value;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            if (Index.Index != 0)
            {
                Value ??= new();
            }
            return this;
        }

        public static implicit operator bool(TObjectPtr<T> self)
        {
            return self is { } && self.Value is { };
        }
    }
}

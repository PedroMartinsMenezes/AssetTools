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
    }

    public class FObjectPtrJsonConverter : JsonConverter<FObjectPtr>
    {
        public override FObjectPtr Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            var index = s.Substring(s.IndexOf('[') + 1, s.IndexOf(']') - s.IndexOf('[') - 1);
            return new FObjectPtr { Index = new(int.Parse(index)) };
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

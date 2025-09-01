using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    public class FObjectPtr : ITransferible
    {
        public FPackageIndex Index;

        [Location("FArchive& FLinkerLoad::operator<<(FObjectPtr& ObjectPtr)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Index);
            return this;
        }
    }

    public class FObjectPtrJsonConverter : JsonConverter<FObjectPtr>
    {
        public override FObjectPtr Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FObjectPtr { Index = new() { Index = reader.GetInt32() } };
        }
        public override void Write(Utf8JsonWriter writer, FObjectPtr value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Index.Index);
        }
        public override FObjectPtr ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return new FObjectPtr { Index = new() { Index = int.Parse(reader.GetString()) } };
        }
        public override void WriteAsPropertyName(Utf8JsonWriter writer, FObjectPtr value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(value.Index.Index.ToString());
        }
    }

    [DebuggerDisplay("{Index}")]
    public class TObjectPtr<T> : ITransferible where T : new()
    {
        public FPackageIndex Index;
        public T Value;

        public ITransferible Move(Transfer transfer)
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

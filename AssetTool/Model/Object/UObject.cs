using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    public class UObject
    {
        [JsonPropertyOrder(-9)] public FName Name = new();
        [JsonPropertyOrder(-9)] public FBool TryEnterField;
    }

    public static class UObjectExt
    {
        public static void Write(this BinaryWriter writer, UObject item)
        {
            writer.Write(item.Name);
            writer.Write(item.TryEnterField);
        }

        public static UObject Read(this BinaryReader reader, UObject item)
        {
            reader.Read(item.Name);
            reader.Read(ref item.TryEnterField);
            return item;
        }
    }
}

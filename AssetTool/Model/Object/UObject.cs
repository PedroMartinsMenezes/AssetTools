using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    public class UObject
    {
        [JsonPropertyOrder(-9)] public List<FPropertyTag> Tags = new();
        [JsonPropertyOrder(-9)] public FBool HasGuid;
        [JsonPropertyOrder(-9)] public FGuid Guid;
    }

    public static class UObjectExt
    {
        public static void Write(this BinaryWriter writer, UObject item)
        {
            item.Tags.ForEach(x => writer.Write(x));
        }

        public static UObject Read(this BinaryReader reader, UObject item)
        {
            reader.Read(item.Tags);
            //2981
            reader.Read(ref item.HasGuid);
            //2985
            if (item.HasGuid.Value)
            {
                reader.Read(ref item.Guid);
            }
            return item;
        }
    }
}

using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    public class UScriptStruct : UStruct
    {
        [JsonPropertyOrder(-7)] public UInt32 StructFlags;
    }

    public static class UScriptStructExt
    {
        public static void Write(this BinaryWriter writer, UScriptStruct item)
        {
            writer.Write((UStruct)item);
        }

        public static UScriptStruct Read(this BinaryReader reader, UScriptStruct item)
        {
            reader.Read((UStruct)item);
            reader.Read(ref item.StructFlags); //3544..3548
            return item;
        }
    }
}

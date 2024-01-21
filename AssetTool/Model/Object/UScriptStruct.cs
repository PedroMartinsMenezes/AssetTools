using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    [Description("void UScriptStruct::Serialize( FArchive& Ar )")]
    public class UScriptStruct : UStruct
    {
        [JsonPropertyOrder(-7)] public UInt32 StructFlags;
    }

    public static class UScriptStructExt
    {
        public static void Write(this BinaryWriter writer, UScriptStruct item)
        {
            writer.Write((UStruct)item);
            writer.Write(item.StructFlags);
        }

        public static void Read(this BinaryReader reader, UScriptStruct item)
        {
            reader.Read((UStruct)item);
            reader.Read(ref item.StructFlags);
        }
    }
}

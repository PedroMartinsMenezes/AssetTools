using System.Text.Json.Serialization;

namespace AssetTool
{
    [Location("void UScriptStruct::Serialize( FArchive& Ar )")]
    public class UScriptStruct : UStruct
    {
        [JsonPropertyOrder(-7)] public UInt32 StructFlags;

        public new UScriptStruct Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref StructFlags);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(StructFlags);
        }
    }
}

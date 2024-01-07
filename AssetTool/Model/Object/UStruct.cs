using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    public class UStruct : UObject
    {
        [JsonPropertyOrder(-8)] public UInt32 AccessTrackedObjectPtr;
        [JsonPropertyOrder(-8)] public List<UField> ChildArray = new();
        [JsonPropertyOrder(-8)] public List<FProperty> ChildProperties = new();
        [JsonPropertyOrder(-8)] public UInt32 BytecodeBufferSize;
        [JsonPropertyOrder(-8)] public UInt32 SerializedScriptSize;
    }

    //void UStruct::Serialize(FArchive& Ar)
    public static class UStructExt
    {
        public static void Write(this BinaryWriter writer, UStruct item)
        {
            writer.Write((UObject)item);

            writer.Write(item.AccessTrackedObjectPtr);
            writer.Write(item.ChildArray);
            writer.Write(item.ChildProperties);
            writer.Write(item.BytecodeBufferSize);
            writer.Write(item.SerializedScriptSize);
        }


        public static UStruct Read(this BinaryReader reader, UStruct item)
        {
            reader.Read((UObject)item);

            reader.Read(ref item.AccessTrackedObjectPtr);
            reader.Read(item.ChildArray);
            reader.Read(item.ChildProperties);
            reader.Read(ref item.BytecodeBufferSize);
            reader.Read(ref item.SerializedScriptSize);
            return item;
        }
    }
}

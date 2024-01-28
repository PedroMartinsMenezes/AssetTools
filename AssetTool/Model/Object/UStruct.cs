using System.ComponentModel;
using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    [Description("void UStruct::Serialize(FArchive& Ar)")]
    public class UStruct : UObject
    {
        [JsonPropertyOrder(-8)] public UInt32 AccessTrackedObjectPtr;
        [JsonPropertyOrder(-8)] public List<FPackageIndex> ChildArray = new();
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

            writer.WriteList(item.ChildArray);

            writer.Write(item.ChildProperties);

            writer.Write(item.BytecodeBufferSize);

            writer.Write(item.SerializedScriptSize);
        }


        public static UStruct Read(this BinaryReader reader, UStruct item)
        {
            reader.Read((UObject)item); //68364..68475

            reader.Read(ref item.AccessTrackedObjectPtr); //68475..68479

            reader.ReadList(item.ChildArray);//68479..68507

            reader.Read(item.ChildProperties);

            reader.Read(ref item.BytecodeBufferSize);

            reader.Read(ref item.SerializedScriptSize);
            return item;
        }
    }
}

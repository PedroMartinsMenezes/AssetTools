using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    public class UStruct : UObject
    {
        [JsonPropertyOrder(-8)] public UInt32 AccessTrackedObjectPtr;
        [JsonPropertyOrder(-8)] public List<UField> ChildArray = new(); //empty
        [JsonPropertyOrder(-8)] public List<FProperty> ChildProperties = new();  //6
        [JsonPropertyOrder(-8)] public UInt32 BytecodeBufferSize;
        [JsonPropertyOrder(-8)] public UInt32 SerializedScriptSize;

        //[0] Rua_2_A8F3454A42017B04C4403E9F8F7D8E5C
        //[1] Numero_5_64A2ADFC4BF1FA294D3F3A9C9284160B
        //[2] CEP_7_6A4D2F2F4894C5B51543D58961680CB1
        //[3] Cidade_10_C7B765EE463B55F13834C982D768BB1B
        //[4] UF_12_A3965E4C416514A9ECDA93AFC9373E9F
        //[5] Complemento_14_FE95298F499E9FFF6D1A398A2D694BE8
    }

    public static class UStructExt
    {
        public static void Write(this BinaryWriter writer, UStruct item)
        {
            writer.Write((UObject)item);
        }

        //void UStruct::Serialize(FArchive& Ar)
        public static UStruct Read(this BinaryReader reader, UStruct item)
        {
            reader.Read((UObject)item); //2879..2985

            reader.Read(ref item.AccessTrackedObjectPtr); //2985..2989

            reader.Read(item.ChildArray); //2989..2993

            reader.Read(item.ChildProperties); //2993..3536

            //FStructScriptLoader
            item.BytecodeBufferSize = reader.ReadUInt32(); //3536..3540
            item.SerializedScriptSize = reader.ReadUInt32(); //3540..3544

            return item;
        }
    }
}

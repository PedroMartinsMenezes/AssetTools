namespace AssetTool.Model
{
    public class UStruct : UObject
    {
        public UInt32 AccessTrackedObjectPtr;

        //List<UField*> ChildArray; //empty
        //List<FProperty> ChildProperties; 
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

        public static UStruct Read(this BinaryReader reader, UStruct item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}

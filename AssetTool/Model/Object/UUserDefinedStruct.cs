using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AssetTool.Model
{
    //2879..3730
    public class UUserDefinedStruct : UScriptStruct
    {
        
    }

    public static class UUserDefinedStructExt
    {
        public static void Write(this BinaryWriter writer, UUserDefinedStruct item)
        {
            writer.Write((UScriptStruct)item); //2879..3548
        }

        public static UUserDefinedStruct Read(this BinaryReader reader, UUserDefinedStruct item)
        {
            reader.Read((UScriptStruct)item); //2879..3548

            reader.Read(item.Tags);

            //[0] //3548..3577
            //  Tag.Name = "Rua_2_A8F3454A42017B04C4403E9F8F7D8E5C"
            //  Tag.Type = "StrProperty"
            //  Tag.Size = 4
            //  Tag.ArrayIndex = 0
            //  Tag.HasPropertyGuid = 0
            //
            //[1]
            //  Tag.Name = "Numero_5_64A2ADFC4BF1FA294D3F3A9C9284160B"
            //  Tag.Type = "IntProperty"
            //  Tag.Size = 4
            //  Tag.ArrayIndex = 0
            //  Tag.HasPropertyGuid = 0
            //
            //[2]
            //  Name = "CEP_7_6A4D2F2F4894C5B51543D58961680CB1"
            //  Tag.Type = "IntProperty"
            //  Tag.Size = 4
            //  Tag.ArrayIndex = 0
            //  Tag.HasPropertyGuid = 0
            //
            //[3]
            //  Tag.Name = "Cidade_10_C7B765EE463B55F13834C982D768BB1B"
            //  Tag.Type = "StrProperty"
            //  Tag.Size = 4
            //  Tag.ArrayIndex = 0
            //  Tag.HasPropertyGuid = 0
            //
            //[4]
            //  Tag.Name = "UF_12_A3965E4C416514A9ECDA93AFC9373E9F"
            //  Tag.Type = "StrProperty"
            //  Tag.Size = 4
            //  Tag.ArrayIndex = 0
            //  Tag.HasPropertyGuid = 0
            //
            //[5]
            //  Tag.Name = "Complemento_14_FE95298F499E9FFF6D1A398A2D694BE8"
            //  Tag.Type = "StrProperty"
            //  Tag.Size = 4
            //  Tag.ArrayIndex = 0
            //  Tag.HasPropertyGuid = 0

            //3730
            //[Novo]
            //  Tag.Name = "UniqueNameId"

            return item;
        }
    }
}

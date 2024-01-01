namespace AssetTool
{
    //2636..2681
    public class ObjectNameToFileOffsetMap
    {
        //TMap< FName, int32 >
        public Dictionary<FName, Int32> Map = new();
    }

    public static class ObjectNameToFileOffsetMapExt
    {
        //TODO implement
        public static void Write(this BinaryWriter writer, ObjectNameToFileOffsetMap item)
        {
            if (item is null) return;
            writer.Write(item.Map.Count);
        }

        //TODO implement
        public static ObjectNameToFileOffsetMap Read(this BinaryReader reader, ObjectNameToFileOffsetMap item)
        {
            int size = reader.ReadInt32();
            if (size > 0)
            {
                FString ObjectShortClassName = reader.ReadFString(); //"UserDefinedStruct"
                FString ObjectPathWithoutPackageName = reader.ReadFString(); //"S_Endereco"

                //UserDefinedStruct /Game/Lab/S_Endereco.S_Endereco

                item.Map.Add(new(), new());
            }
            return item;
        }
    }
}

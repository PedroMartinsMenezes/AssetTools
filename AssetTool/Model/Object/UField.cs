namespace AssetTool
{
    public class UField : UObject
    {
        public UField Next;
    }

    public static class UFieldExt
    {
        public static void Write(this BinaryWriter writer, List<UField> list)
        {
            writer.Write(list.Count);
            list.ForEach(writer.Write);
        }

        public static void Write(this BinaryWriter writer, UField item)
        {
            writer.Write((UObject)item);
        }

        //static FArchive& Serialize(FArchive& Ar, TArray<ElementType, AllocatorType>& A)
        public static void Read(this BinaryReader reader, List<UField> item)
        {
            int size = reader.ReadInt32(); //OK
            for (int i = 0; i < size; i++)
            {
                //FArchive& FLinkerLoad::operator<<( UObject*& Object )
                FPackageIndex index = new();
                reader.Read(ref index.Index);

                item.Add(reader.Read(new UField())); //Erro
            }
        }

        public static UField Read(this BinaryReader reader, UField item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}

namespace AssetTool.Model
{
    public class UField : UObject
    {
        public UField Next;
    }

    public static class UFieldExt
    {
        public static void Write(this BinaryWriter writer, UField item)
        {
            writer.Write((UObject)item);
        }

        public static void Read(this BinaryReader reader, List<UField> item)
        {
            int size = reader.ReadInt32();
            for (int i = 0; i < size; i++)
            {
                item.Add(reader.Read(new UField()));
            }
        }

        public static UField Read(this BinaryReader reader, UField item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}

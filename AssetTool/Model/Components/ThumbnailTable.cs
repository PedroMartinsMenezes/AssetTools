namespace AssetTool
{
    //2636..2681
    public class ThumbnailTable
    {
        //TMap< FName, int32 >
        public Dictionary<string, Int32> Map = new();
    }

    public static class ObjectNameToFileOffsetMapExt
    {
        public static void Write(this BinaryWriter writer, ThumbnailTable item, int offset)
        {
            if (item is null) return;
            writer.BaseStream.Position = offset;

            writer.Write(item.Map.Count);
            foreach (var pair in item.Map)
            {
                string[] names = pair.Key.Split(" ");

                FString ObjectShortClassName = new FString(names[0]);
                FString ObjectPathWithoutPackageName = new FString(names[1]);
                int FileOffset = pair.Value;

                writer.Write(ObjectShortClassName);
                writer.Write(ObjectPathWithoutPackageName);
                writer.Write(FileOffset);
            }
        }

        public static ThumbnailTable ReadThumbnailTable(this BinaryReader reader, int offset)
        {
            reader.BaseStream.Position = offset;
            ThumbnailTable item = new();
            int size = reader.ReadInt32();
            if (size > 0)
            {
                FString ObjectShortClassName = reader.Read((FString)null); //"UserDefinedStruct"
                FString ObjectPathWithoutPackageName = reader.Read((FString)null); //"S_Endereco"
                int FileOffset = reader.ReadInt32();

                var key = $"{ObjectShortClassName.Value} {ObjectPathWithoutPackageName.Value}";
                var value = FileOffset;

                item.Map.Add(key, value);
            }
            return item;
        }
    }
}

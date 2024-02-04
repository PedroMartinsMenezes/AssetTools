namespace AssetTool
{
    [Location("void UBlueprintGeneratedClass::Serialize(FArchive& Ar)")]
    public class UBlueprintGeneratedClass : UClass
    {
    }

    public static class UBlueprintGeneratedClassExt
    {
        public static void Write(this BinaryWriter writer, UBlueprintGeneratedClass item)
        {
            writer.Write((UClass)item);
        }

        public static UBlueprintGeneratedClass Read(this BinaryReader reader, UBlueprintGeneratedClass item)
        {
            reader.Read((UClass)item);//68364..68850
            return item;
        }
    }
}

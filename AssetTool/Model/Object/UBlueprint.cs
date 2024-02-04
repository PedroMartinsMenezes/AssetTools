namespace AssetTool
{
    [Location("void UBlueprint::Serialize(FArchive& Ar)")]
    public class UBlueprint : UBlueprintCore
    {
    }

    public static class UBlueprintExt
    {
        public static void Write(this BinaryWriter writer, UBlueprint item)
        {
            writer.Write((UBlueprintCore)item);
        }

        public static UBlueprint Read(this BinaryReader reader, UBlueprint item)
        {
            reader.Read((UBlueprintCore)item);
            return item; //5134
        }
    }
}

namespace AssetTool.Model
{
    public class UBlueprint : UObject
    {
    }

    public static class UBlueprintExt
    {
        public static void Write(this BinaryWriter writer, UBlueprint item)
        {
            writer.Write((UObject)item);
        }

        public static UBlueprint Read(this BinaryReader reader, UBlueprint item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}

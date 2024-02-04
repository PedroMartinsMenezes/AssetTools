namespace AssetTool
{
    public class UDynamicBlueprintBinding : UObject
    {
    }

    public static class UDynamicBlueprintBindingExt
    {
        public static void Write(this BinaryWriter writer, UDynamicBlueprintBinding item)
        {
            writer.Write((UObject)item);
        }

        public static UDynamicBlueprintBinding Read(this BinaryReader reader, UDynamicBlueprintBinding item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}

namespace AssetTool
{
    public class USimpleConstructionScript : UObject
    {
    }

    public static class USimpleConstructionScriptExt
    {
        public static void Write(this BinaryWriter writer, USimpleConstructionScript item)
        {
            writer.Write((UObject)item);
        }

        public static USimpleConstructionScript Read(this BinaryReader reader, USimpleConstructionScript item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}

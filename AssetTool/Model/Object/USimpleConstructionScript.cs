namespace AssetTool
{
    [Location("void USimpleConstructionScript::Serialize(FArchive& Ar)")]
    public class USimpleConstructionScript : UObject
    {
        public const string TypeName = "SimpleConstructionScript";
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

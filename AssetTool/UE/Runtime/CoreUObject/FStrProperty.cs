namespace AssetTool
{
    [Location("class COREUOBJECT_API FStrProperty : public FStrProperty_Super")]
    public class FStrProperty : FProperty
    {
        public override string TypeName => "StrProperty";
    }

    public static class FStrPropertyExt
    {
        public static void Write(this BinaryWriter writer, FStrProperty item)
        {
            writer.Write((FProperty)item);
        }

        public static FStrProperty Read(this BinaryReader reader, FStrProperty item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

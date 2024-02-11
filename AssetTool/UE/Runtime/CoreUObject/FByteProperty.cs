namespace AssetTool
{
    [Location("class COREUOBJECT_API FByteProperty : public TProperty_Numeric<uint8>")]
    public class FByteProperty : FNumericProperty
    {
        public const string TYPE_NAME = "ByteProperty";
        public override string TypeName => TYPE_NAME;
    }

    public static class FBytePropertyExt
    {
        public static void Write(this BinaryWriter writer, FByteProperty item)
        {
            writer.Write((FProperty)item);
        }

        public static FByteProperty Read(this BinaryReader reader, FByteProperty item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

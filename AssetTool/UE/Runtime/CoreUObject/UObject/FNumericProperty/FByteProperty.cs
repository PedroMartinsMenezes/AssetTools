namespace AssetTool
{
    [Location("class COREUOBJECT_API FByteProperty : public TProperty_Numeric<uint8>")]
    public class FByteProperty : FNumericProperty
    {
        public const string TYPE_NAME = "ByteProperty";
        public override string TypeName => TYPE_NAME;

        public static byte ReadValue(BinaryReader reader)
        {
            return reader.ReadByte();
        }
        public static void WriteValue(BinaryWriter writer, byte value)
        {
            writer.Write(value);
        }
    }
}

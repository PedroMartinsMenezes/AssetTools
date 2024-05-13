namespace AssetTool
{
    [Location("class COREUOBJECT_API FInt8Property : public TProperty_Numeric<int8>")]
    public class FInt8Property : FNumericProperty
    {
        public const string TYPE_NAME = "Int8Property";
        public override string TypeName => TYPE_NAME;

        public static sbyte ReadValue(BinaryReader reader)
        {
            return reader.ReadSByte();
        }
        public static void WriteValue(BinaryWriter writer, sbyte value)
        {
            writer.Write(value);
        }
    }
}

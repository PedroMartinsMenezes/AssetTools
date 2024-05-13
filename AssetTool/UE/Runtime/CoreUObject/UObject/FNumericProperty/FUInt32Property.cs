namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt32Property : public TProperty_Numeric<uint32>")]
    public class FUInt32Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt32Property";
        public override string TypeName => TYPE_NAME;

        public static UInt32 ReadValue(BinaryReader reader)
        {
            return reader.ReadUInt32();
        }
        public static void WriteValue(BinaryWriter writer, UInt32 value)
        {
            writer.Write(value);
        }
    }
}

namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt16Property : public TProperty_Numeric<uint16>")]
    public class FUInt16Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt16Property";
        public override string TypeName => TYPE_NAME;

        public new FUInt16Property Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }

        public static UInt16 ReadValue(BinaryReader reader)
        {
            return reader.ReadUInt16();
        }
        public static void WriteValue(BinaryWriter writer, UInt16 value)
        {
            writer.Write(value);
        }
    }
}

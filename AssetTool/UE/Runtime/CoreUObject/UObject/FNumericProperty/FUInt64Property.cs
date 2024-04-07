namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt64Property : public TProperty_Numeric<uint64>")]
    public class FUInt64Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt64Property";
        public override string TypeName => TYPE_NAME;

        public new FUInt64Property Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }

        public static UInt64 ReadValue(BinaryReader reader)
        {
            return reader.ReadUInt64();
        }
        public static void WriteValue(BinaryWriter writer, UInt64 value)
        {
            writer.Write(value);
        }
    }
}

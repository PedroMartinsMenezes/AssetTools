namespace AssetTool
{
    [Location("class COREUOBJECT_API FInt16Property : public TProperty_Numeric<int16>")]
    public class FInt16Property : FNumericProperty
    {
        public const string TYPE_NAME = "Int16Property";
        public override string TypeName => TYPE_NAME;

        public new FInt16Property Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }

        public static Int16 ReadValue(BinaryReader reader)
        {
            return reader.ReadInt16();
        }
        public static void WriteValue(BinaryWriter writer, Int16 value)
        {
            writer.Write(value);
        }
    }
}

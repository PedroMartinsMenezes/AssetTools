namespace AssetTool
{
    [Location("class COREUOBJECT_API FInt64Property : public TProperty_Numeric<int64>")]
    public class FInt64Property : FNumericProperty
    {
        public const string TYPE_NAME = "Int64Property";
        public override string TypeName => TYPE_NAME;

        public static Int64 ReadValue(BinaryReader reader)
        {
            return reader.ReadInt64();
        }
        public static void WriteValue(BinaryWriter writer, Int64 value)
        {
            writer.Write(value);
        }
    }
}

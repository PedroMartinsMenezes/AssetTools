namespace AssetTool
{
    [Location("class COREUOBJECT_API FDoubleProperty : public TProperty_Numeric<double>")]
    public class FDoubleProperty : FNumericProperty
    {
        public const string TYPE_NAME = "DoubleProperty";
        public override string TypeName => TYPE_NAME;

        public static double ReadValue(BinaryReader reader)
        {
            return reader.ReadDouble();
        }
        public static void WriteValue(BinaryWriter writer, double value)
        {
            writer.Write(value);
        }
    }
}

namespace AssetTool
{
    [Location("class COREUOBJECT_API FFloatProperty : public TProperty_Numeric<float>")]
    public class FFloatProperty : FNumericProperty
    {
        public const string TYPE_NAME = "FloatProperty";
        public override string TypeName => TYPE_NAME;

        public static float ReadValue(BinaryReader reader)
        {
            return reader.ReadSingle();
        }
        public static void WriteValue(BinaryWriter writer, float value)
        {
            writer.Write(value);
        }
    }
}

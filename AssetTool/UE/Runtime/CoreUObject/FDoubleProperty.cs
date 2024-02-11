namespace AssetTool
{
    [Location("class COREUOBJECT_API FDoubleProperty : public TProperty_Numeric<double>")]
    public class FDoubleProperty : FNumericProperty
    {
        public const string TYPE_NAME = "DoubleProperty";
        public override string TypeName => TYPE_NAME;
    }

    public static class FDoublePropertyExt
    {
        public static void Write(this BinaryWriter writer, FDoubleProperty item)
        {
            writer.Write((FProperty)item);
        }

        public static FDoubleProperty Read(this BinaryReader reader, FDoubleProperty item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

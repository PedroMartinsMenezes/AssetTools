namespace AssetTool
{
    [Location("class COREUOBJECT_API FDoubleProperty : public TProperty_Numeric<double>")]
    public class FDoubleProperty : FNumericProperty
    {
        public override string TypeName => "DoubleProperty";

        public double Value;
    }

    public static class FDoublePropertyExt
    {
        public static void Write(this BinaryWriter writer, FDoubleProperty item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.Value);
        }

        public static FDoubleProperty Read(this BinaryReader reader, FDoubleProperty item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.Value);
            return item;
        }
    }
}

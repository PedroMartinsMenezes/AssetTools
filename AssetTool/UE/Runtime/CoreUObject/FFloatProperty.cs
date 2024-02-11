namespace AssetTool
{
    [Location("class COREUOBJECT_API FFloatProperty : public TProperty_Numeric<float>")]
    public class FFloatProperty : FNumericProperty
    {
        public const string TYPE_NAME = "FloatProperty";
        public override string TypeName => TYPE_NAME;
    }

    public static class FFloatPropertyExt
    {
        public static void Write(this BinaryWriter writer, FFloatProperty item)
        {
            writer.Write((FProperty)item);
        }

        public static FFloatProperty Read(this BinaryReader reader, FFloatProperty item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

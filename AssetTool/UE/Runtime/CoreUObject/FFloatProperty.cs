namespace AssetTool
{
    [Location("class COREUOBJECT_API FFloatProperty : public TProperty_Numeric<float>")]
    public class FFloatProperty : FNumericProperty
    {
        public override string TypeName => "FloatProperty";

        public float Value;
    }

    public static class FFloatPropertyExt
    {
        public static void Write(this BinaryWriter writer, FFloatProperty item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.Value);
        }

        public static FFloatProperty Read(this BinaryReader reader, FFloatProperty item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.Value);
            return item;
        }
    }
}

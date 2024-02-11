namespace AssetTool
{
    [Location("class COREUOBJECT_API FInt8Property : public TProperty_Numeric<int8>")]
    public class FInt8Property : FNumericProperty
    {
        public const string TYPE_NAME = "Int8Property";
        public override string TypeName => TYPE_NAME;
    }

    public static class FInt8PropertyExt
    {
        public static void Write(this BinaryWriter writer, FInt8Property item)
        {
            writer.Write((FProperty)item);
        }

        public static FInt8Property Read(this BinaryReader reader, FInt8Property item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

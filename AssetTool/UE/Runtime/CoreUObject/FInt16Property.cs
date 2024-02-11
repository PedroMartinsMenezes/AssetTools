namespace AssetTool
{
    [Location("class COREUOBJECT_API FInt16Property : public TProperty_Numeric<int16>")]
    public class FInt16Property : FNumericProperty
    {
        public const string TYPE_NAME = "Int16Property";
        public override string TypeName => TYPE_NAME;
    }

    public static class FInt16PropertyExt
    {
        public static void Write(this BinaryWriter writer, FInt16Property item)
        {
            writer.Write((FProperty)item);
        }

        public static FInt16Property Read(this BinaryReader reader, FInt16Property item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

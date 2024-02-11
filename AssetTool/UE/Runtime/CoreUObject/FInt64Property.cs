namespace AssetTool
{
    [Location("class COREUOBJECT_API FInt64Property : public TProperty_Numeric<int64>")]
    public class FInt64Property : FNumericProperty
    {
        public const string TYPE_NAME = "Int64Property";
        public override string TypeName => TYPE_NAME;
    }

    public static class FInt64PropertyExt
    {
        public static void Write(this BinaryWriter writer, FInt64Property item)
        {
            writer.Write((FProperty)item);
        }

        public static FInt64Property Read(this BinaryReader reader, FInt64Property item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

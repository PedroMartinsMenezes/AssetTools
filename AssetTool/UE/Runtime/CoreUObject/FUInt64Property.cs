namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt64Property : public TProperty_Numeric<uint64>")]
    public class FUInt64Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt32Property";
        public override string TypeName => TYPE_NAME;
    }

    public static class FUInt64PropertyExt
    {
        public static void Write(this BinaryWriter writer, FUInt64Property item)
        {
            writer.Write((FProperty)item);
        }

        public static FUInt64Property Read(this BinaryReader reader, FUInt64Property item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

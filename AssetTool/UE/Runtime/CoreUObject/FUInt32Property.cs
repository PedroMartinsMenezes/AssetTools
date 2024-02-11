namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt32Property : public TProperty_Numeric<uint32>")]
    public class FUInt32Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt32Property";
        public override string TypeName => TYPE_NAME;
    }

    public static class FUInt32PropertyExt
    {
        public static void Write(this BinaryWriter writer, FUInt32Property item)
        {
            writer.Write((FProperty)item);
        }

        public static FUInt32Property Read(this BinaryReader reader, FUInt32Property item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

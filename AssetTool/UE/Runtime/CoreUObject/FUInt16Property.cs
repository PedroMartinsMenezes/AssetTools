namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt16Property : public TProperty_Numeric<uint16>")]
    public class FUInt16Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt16Property";
        public override string TypeName => TYPE_NAME;
    }

    public static class FUInt16PropertyExt
    {
        public static void Write(this BinaryWriter writer, FUInt16Property item)
        {
            writer.Write((FProperty)item);
        }

        public static FUInt16Property Read(this BinaryReader reader, FUInt16Property item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

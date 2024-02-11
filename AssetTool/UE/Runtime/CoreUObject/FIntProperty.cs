namespace AssetTool
{
    [Location("class COREUOBJECT_API FIntProperty : public TProperty_Numeric<int32>")]
    public class FIntProperty : FNumericProperty
    {
        public const string TYPE_NAME = "IntProperty";
        public override string TypeName => TYPE_NAME;
    }

    public static class FIntPropertyExt
    {
        public static void Write(this BinaryWriter writer, FIntProperty item)
        {
            writer.Write((FProperty)item);
        }

        public static FIntProperty Read(this BinaryReader reader, FIntProperty item)
        {
            reader.Read((FProperty)item);
            return item;
        }
    }
}

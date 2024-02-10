namespace AssetTool
{
    [Location("class COREUOBJECT_API FIntProperty : public TProperty_Numeric<int32>")]
    public class FIntProperty : FNumericProperty
    {
        public override string TypeName => "IntProperty";

        //public Int32 Value;
    }

    public static class FIntPropertyExt
    {
        public static void Write(this BinaryWriter writer, FIntProperty item)
        {
            writer.Write((FProperty)item);
            //writer.Write(item.Value);
        }

        public static FIntProperty Read(this BinaryReader reader, FIntProperty item)
        {
            reader.Read((FProperty)item);
            //reader.Read(ref item.Value);
            return item;
        }
    }
}

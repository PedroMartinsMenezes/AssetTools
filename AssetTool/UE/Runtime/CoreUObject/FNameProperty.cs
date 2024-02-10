namespace AssetTool
{
    [Location("class COREUOBJECT_API FNameProperty : public FNameProperty_Super")]
    public class FNameProperty : FProperty
    {
        public override string TypeName => "StrProperty";

        public FName Value;
    }

    public static class FNamePropertyExt
    {
        public static void Write(this BinaryWriter writer, FNameProperty item)
        {
            writer.Write((FProperty)item);
            writer.Write(item.Value);
        }

        public static FNameProperty Read(this BinaryReader reader, FNameProperty item)
        {
            reader.Read((FProperty)item);
            reader.Read(ref item.Value);
            return item;
        }
    }
}

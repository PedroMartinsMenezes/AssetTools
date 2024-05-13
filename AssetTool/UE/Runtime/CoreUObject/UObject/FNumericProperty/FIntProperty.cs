namespace AssetTool
{
    [Location("class COREUOBJECT_API FIntProperty : public TProperty_Numeric<int32>")]
    public class FIntProperty : FNumericProperty
    {
        public const string TYPE_NAME = "IntProperty";
        public override string TypeName => TYPE_NAME;

        public static Int32 ReadValue(BinaryReader reader)
        {
            return reader.ReadInt32();
        }
        public static void WriteValue(BinaryWriter writer, Int32 value)
        {
            writer.Write(value);
        }
    }
}

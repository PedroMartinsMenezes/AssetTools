namespace AssetTool
{
    [Location("class COREUOBJECT_API FByteProperty : public TProperty_Numeric<uint8>")]
    public class FByteProperty : FNumericProperty
    {
        public const string TYPE_NAME = "ByteProperty";
        public override string TypeName => TYPE_NAME;

        public new FByteProperty Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}

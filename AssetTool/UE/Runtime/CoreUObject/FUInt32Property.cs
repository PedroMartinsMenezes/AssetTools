namespace AssetTool
{
    [Location("class COREUOBJECT_API FUInt32Property : public TProperty_Numeric<uint32>")]
    public class FUInt32Property : FNumericProperty
    {
        public const string TYPE_NAME = "UInt32Property";
        public override string TypeName => TYPE_NAME;

        public new FUInt32Property Read(BinaryReader reader)
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

namespace AssetTool
{
    [Location("class COREUOBJECT_API FInt8Property : public TProperty_Numeric<int8>")]
    public class FInt8Property : FNumericProperty
    {
        public const string TYPE_NAME = "Int8Property";
        public override string TypeName => TYPE_NAME;

        public new FInt8Property Read(BinaryReader reader)
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

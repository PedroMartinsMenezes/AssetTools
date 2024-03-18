namespace AssetTool
{
    [Location("class COREUOBJECT_API FInt64Property : public TProperty_Numeric<int64>")]
    public class FInt64Property : FNumericProperty
    {
        public const string TYPE_NAME = "Int64Property";
        public override string TypeName => TYPE_NAME;

        public new FInt64Property Read(BinaryReader reader)
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

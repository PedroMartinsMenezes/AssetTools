namespace AssetTool
{
    [Location("class COREUOBJECT_API FFloatProperty : public TProperty_Numeric<float>")]
    public class FFloatProperty : FNumericProperty
    {
        public const string TYPE_NAME = "FloatProperty";
        public override string TypeName => TYPE_NAME;

        public new FFloatProperty Read(BinaryReader reader)
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

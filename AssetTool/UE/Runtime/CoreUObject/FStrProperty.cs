namespace AssetTool
{
    [Location("class COREUOBJECT_API FStrProperty : public FStrProperty_Super")]
    public class FStrProperty : FProperty
    {
        public const string TYPE_NAME = "StrProperty";
        public override string TypeName => TYPE_NAME;

        public new FStrProperty Read(BinaryReader reader)
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

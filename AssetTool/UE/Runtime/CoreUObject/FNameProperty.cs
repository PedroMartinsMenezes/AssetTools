namespace AssetTool
{
    [Location("class COREUOBJECT_API FNameProperty : public FNameProperty_Super")]
    public class FNameProperty : FProperty
    {
        public const string TYPE_NAME = "NameProperty";
        public override string TypeName => TYPE_NAME;

        public FName Value;

        public new FNameProperty Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref Value);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(Value);
        }
    }
}

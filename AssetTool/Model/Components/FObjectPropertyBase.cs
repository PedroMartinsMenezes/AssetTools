namespace AssetTool
{
    [Location("void FObjectPropertyBase::Serialize( FArchive& Ar )")]
    public class FObjectPropertyBase : FProperty
    {
        public const string TYPE_NAME = "ObjectProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        public new FObjectPropertyBase Read(BinaryReader reader)
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

namespace AssetTool
{
    [Location("void FStructProperty::Serialize( FArchive& Ar )")]
    public class FStructProperty : FProperty
    {
        public const string TYPE_NAME = "StructProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        public new FStructProperty Read(BinaryReader reader)
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

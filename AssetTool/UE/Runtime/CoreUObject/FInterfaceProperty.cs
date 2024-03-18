namespace AssetTool
{
    [Location("void FInterfaceProperty::Serialize( FArchive& Ar )")]
    public class FInterfaceProperty : FProperty
    {
        public const string TYPE_NAME = "InterfaceProperty";
        public override string TypeName => TYPE_NAME;

        public UInt32 Value;

        public new FInterfaceProperty Read(BinaryReader reader)
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

namespace AssetTool
{
    [Location("void FMulticastDelegateProperty::Serialize( FArchive& Ar )")]
    public class FMulticastDelegateProperty : FProperty
    {
        public UInt32 SignatureFunction;

        public new FMulticastDelegateProperty Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref SignatureFunction);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(SignatureFunction);
        }
    }
}

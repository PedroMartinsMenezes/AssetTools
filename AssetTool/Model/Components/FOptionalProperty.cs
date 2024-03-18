namespace AssetTool
{
    [Location("void FOptionalProperty::Serialize(FArchive& Ar)")]
    public class FOptionalProperty : FProperty
    {
        public FName PropertyTypeName;

        public new FOptionalProperty Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref PropertyTypeName);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(PropertyTypeName);
        }
    }
}

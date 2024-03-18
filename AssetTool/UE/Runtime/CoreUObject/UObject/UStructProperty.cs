namespace AssetTool
{
    [Location("void UStructProperty::Serialize(FArchive& Ar)")]
    public class UStructProperty : UProperty
    {
        public const string TypeName = "StructProperty";

        public UInt32 StructPtr;

        public new UStructProperty Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref StructPtr);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(StructPtr);
        }
    }
}

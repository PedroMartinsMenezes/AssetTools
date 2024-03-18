namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UByteProperty : UNumericProperty
    {
        public const string TypeName = "ByteProperty";

        public new UByteProperty Read(BinaryReader reader)
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

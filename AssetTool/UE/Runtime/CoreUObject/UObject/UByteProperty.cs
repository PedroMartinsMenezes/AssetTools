namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UByteProperty : UNumericProperty
    {
        public const string TypeName = "ByteProperty";

        public new UByteProperty Read(BinaryReader reader)
        {
            reader.Read((UNumericProperty)this);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            writer.Write((UNumericProperty)this);
        }
    }
}

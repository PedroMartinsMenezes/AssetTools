namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UNumericProperty : UProperty
    {
        public new UNumericProperty Read(BinaryReader reader)
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

namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UNumericProperty : UProperty
    {
        public UNumericProperty Read(BinaryReader reader)
        {
            reader.Read((UProperty)this);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write((UProperty)this);
        }
    }
}

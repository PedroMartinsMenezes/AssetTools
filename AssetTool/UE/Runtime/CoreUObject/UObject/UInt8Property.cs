namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UInt8Property : UNumericProperty
    {
        public const string TypeName = "Int8Property";

        public new UInt8Property Read(BinaryReader reader)
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

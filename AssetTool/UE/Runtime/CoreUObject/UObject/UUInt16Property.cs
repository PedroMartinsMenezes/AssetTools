namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UUInt16Property : UNumericProperty
    {
        public const string TypeName = "UInt16Property";

        public new UUInt16Property Read(BinaryReader reader)
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

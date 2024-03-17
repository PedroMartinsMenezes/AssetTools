namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UUInt64Property : UNumericProperty
    {
        public const string TypeName = "UInt64Property";

        public new UUInt64Property Read(BinaryReader reader)
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

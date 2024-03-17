namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UUInt32Property : UNumericProperty
    {
        public const string TypeName = "UInt32Property";

        public new UUInt32Property Read(BinaryReader reader)
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

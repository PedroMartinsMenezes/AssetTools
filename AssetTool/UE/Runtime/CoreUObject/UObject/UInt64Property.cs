namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UInt64Property : UNumericProperty
    {
        public const string TypeName = "Int64Property";

        public new UInt64Property Read(BinaryReader reader)
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

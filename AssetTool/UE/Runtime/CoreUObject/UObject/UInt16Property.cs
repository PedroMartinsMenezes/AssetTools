namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UInt16Property : UNumericProperty
    {
        public const string TypeName = "Int16Property";

        public new UInt16Property Read(BinaryReader reader)
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

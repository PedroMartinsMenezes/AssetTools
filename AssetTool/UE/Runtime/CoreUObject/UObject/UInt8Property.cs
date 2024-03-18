namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UInt8Property : UNumericProperty
    {
        public const string TypeName = "Int8Property";

        public new UInt8Property Read(BinaryReader reader)
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

namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UInt64Property : UNumericProperty
    {
        public const string TypeName = "Int64Property";

        public new UInt64Property Read(BinaryReader reader)
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

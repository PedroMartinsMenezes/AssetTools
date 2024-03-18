namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UUInt32Property : UNumericProperty
    {
        public const string TypeName = "UInt32Property";

        public new UUInt32Property Read(BinaryReader reader)
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

namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UIntProperty : UNumericProperty
    {
        public const string TypeName = "IntProperty";

        public new UIntProperty Read(BinaryReader reader)
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

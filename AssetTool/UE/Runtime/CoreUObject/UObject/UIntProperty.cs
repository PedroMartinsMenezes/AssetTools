namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UIntProperty : UNumericProperty
    {
        public const string TypeName = "IntProperty";

        public new UIntProperty Read(BinaryReader reader)
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

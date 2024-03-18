namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UDoubleProperty : UNumericProperty
    {
        public const string TypeName = "DoubleProperty";

        public new UDoubleProperty Read(BinaryReader reader)
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

namespace AssetTool
{
    [Location("void UProperty::Serialize( FArchive& Ar )")]
    public class UFloatProperty : UNumericProperty
    {
        public const string TypeName = "FloatProperty";

        public new UFloatProperty Read(BinaryReader reader)
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

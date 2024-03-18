namespace AssetTool
{
    [Location("void FNumericProperty::Serialize(FArchive& Ar)")]
    public class FNumericProperty : FProperty
    {
        public new FNumericProperty Read(BinaryReader reader)
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

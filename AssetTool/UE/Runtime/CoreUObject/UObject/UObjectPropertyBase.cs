namespace AssetTool
{
    [Location("void UObjectPropertyBase::Serialize(FArchive& Ar)")]
    public class UObjectPropertyBase : UProperty
    {
        public UInt32 PropertyClass;

        public new UObjectPropertyBase Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref PropertyClass);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(PropertyClass);
        }
    }
}

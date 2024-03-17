namespace AssetTool
{
    [Location("void UStructProperty::Serialize(FArchive& Ar)")]
    public class UStructProperty : UProperty
    {
        public const string TypeName = "StructProperty";

        public UInt32 StructPtr;

        public UStructProperty Read(BinaryReader reader)
        {
            reader.Read((UProperty)this);
            reader.Read(ref StructPtr);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write((UProperty)this);
            writer.Write(StructPtr);
        }
    }
}

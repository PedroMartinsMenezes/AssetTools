namespace AssetTool
{
    [Location("void UField::Serialize( FArchive& Ar )")]
    public class UField : UObject
    {
        public UInt32 Next;

        public UField Read(BinaryReader reader)
        {
            base.Read(reader);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                reader.Read(ref Next);
            }
            return this;
        }

        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                writer.Write(Next);
            }
        }
    }
}

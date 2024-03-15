namespace AssetTool
{
    [Location("FArchive& FLinkerLoad::operator<<(FObjectPtr& ObjectPtr)")]
    public class FObjectPtr
    {
        public FPackageIndex Index;
        public UInt32 Ptr;

        public FObjectPtr() { }

        public void Read(BinaryReader reader)
        {
            Index = new FPackageIndex { Index = reader.ReadInt32() };
            if (Index.Index > 0)
            {
                Ptr = reader.ReadUInt32();
            }
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Index.Index);
            if (Index.Index > 0)
            {
                writer.Write(Ptr);
            }
        }
    }
}

namespace AssetTool
{
    public class FHeader
    {
        public UInt64 Tag;
        public UInt32 Version;
        public UInt32 HeaderLength;
        public UInt64 PayloadsDataLength;
        public List<FLookupTableEntry> PayloadLookupTable = new();
    };

    public class FLookupTableEntry
    {
        public FIoHash Identifier = new();
        public Int64 OffsetInFile;
        public UInt64 CompressedSize;
        public UInt64 RawSize;
        public UInt16 EPayloadFlags_Flags;
        public UInt16 EPayloadFilterReason_FilterFlags;
        public byte EPayloadAccessMode_AccessMode;
    }

    public class FIoHash
    {
        public byte[] ByteArray = new byte[20];

        public FIoHash Read(BinaryReader reader)
        {
            reader.Read(ByteArray);
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(ByteArray);
        }
    }
}

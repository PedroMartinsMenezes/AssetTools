namespace AssetTool
{
    public class FEditorBulkData
    {
        public UInt32 Flags;
        public FGuid BulkDataId;
        public FIoHash PayloadContentId;
        public Int64 PayloadSize;

        public FEditorBulkData Read(BinaryReader reader)
        {
            reader.Read(ref Flags);
            reader.Read(ref BulkDataId);
            PayloadContentId = new FIoHash().Read(reader);
            reader.Read(ref PayloadSize);
            return this;
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(Flags);
            writer.Write(BulkDataId);
            PayloadContentId.Write(writer);
            writer.Write(PayloadSize);
        }
    }
}

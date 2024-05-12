namespace AssetTool
{
    public class FEditorBulkData
    {
        public UInt32 Flags;
        public FGuid BulkDataId;
        public FIoHash PayloadContentId = new();
        public Int64 PayloadSize;

        public FEditorBulkData Move(Transfer transfer)
        {
            transfer.Move(ref Flags);
            transfer.Move(ref BulkDataId);
            PayloadContentId.Move(transfer);
            transfer.Move(ref PayloadSize);
            return this;
        }
    }
}

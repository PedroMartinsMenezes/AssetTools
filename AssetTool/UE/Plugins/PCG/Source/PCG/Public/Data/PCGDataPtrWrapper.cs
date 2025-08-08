namespace AssetTool
{
    [TransferibleStruct("PCGDataPtrWrapper")]
    public class FPCGDataPtrWrapper : ITransferible
    {
        public FObjectPtr Data;

        [Location("bool FPCGDataPtrWrapper::Serialize(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Data);
            return this;
        }
    }
}

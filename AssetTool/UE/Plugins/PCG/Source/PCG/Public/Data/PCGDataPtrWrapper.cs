namespace AssetTool
{
    [TransferableStruct("PCGDataPtrWrapper")]
    public class FPCGDataPtrWrapper : ITransferable
    {
        public FObjectPtr Data;

        [Location("bool FPCGDataPtrWrapper::Serialize(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Data);
            return this;
        }
    }
}

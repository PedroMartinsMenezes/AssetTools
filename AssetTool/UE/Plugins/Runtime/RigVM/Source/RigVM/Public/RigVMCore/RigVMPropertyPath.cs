namespace AssetTool
{
    public class FRigVMPropertyPathDescription : ITransferible
    {
        public Int32 PropertyIndex;
        public FString HeadCPPType;
        public FString SegmentPath;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMPropertyPathDescription& Path)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref PropertyIndex);
            transfer.Move(ref HeadCPPType);
            transfer.Move(ref SegmentPath);
            return this;
        }
    }
}

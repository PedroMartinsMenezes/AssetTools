namespace AssetTool
{
    public class FRigVMGraphFunctionStore : ITransferable
    {
        public List<FRigVMGraphFunctionData> PublicFunctions;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMGraphFunctionStore& Host)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref PublicFunctions);
            return this;
        }
    }
}

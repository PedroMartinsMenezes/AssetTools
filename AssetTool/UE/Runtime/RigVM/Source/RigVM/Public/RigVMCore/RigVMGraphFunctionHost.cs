namespace AssetTool
{
    public class FRigVMGraphFunctionStore : ITransferible
    {
        public List<FRigVMGraphFunctionData> PublicFunctions;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMGraphFunctionStore& Host)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref PublicFunctions);
            return this;
        }
    }
}

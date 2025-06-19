namespace AssetTool
{
    public class FRigVMGraphFunctionStore : ITransferible
    {
        public List<FRigVMGraphFunctionData> PublicFunctions;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMGraphFunctionStore& Host)")]
        public ITransferible Move2(Transfer transfer)
        {
            transfer.Move(ref PublicFunctions);
            return this;
        }
    }
}

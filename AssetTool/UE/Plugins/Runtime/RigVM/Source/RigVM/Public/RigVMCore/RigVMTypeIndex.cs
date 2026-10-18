namespace AssetTool
{
    public class TRigVMTypeIndex : ITransferable
    {
        public FName CPPType;
        public FObjectPtr CPPTypeObject;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref CPPType);
            transfer.Move(ref CPPTypeObject);
            return this;
        }
    }
}

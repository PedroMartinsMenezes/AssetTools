namespace AssetTool
{
    public class FRigVMTemplateArgumentType : ITransferable
    {
        public FName CPPType;
        public FObjectPtr CPPTypeObject;

        [Location("void FRigVMTemplateArgumentType::Serialize_NoLock(FArchive& Ar)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref CPPType);
            transfer.Move(ref CPPTypeObject);
            return this;
        }
    }

    public class FRigVMTemplateArgumentInfo : ITransferable
    {
        public FName Name;
        public int32 Direction;
        public List<TRigVMTypeIndex> Types;

        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref Direction);
            transfer.Move(ref Types);
            return this;
        }
    }
}

namespace AssetTool
{
    public class FRigVMMemoryStorageStruct : FInstancedPropertyBag
    {
        public ERigVMMemoryType MemoryType;
        public List<FRigVMPropertyPathDescription> PropertyPathDescriptions;

        [Location("bool FRigVMMemoryStorageStruct::Serialize(FArchive& Ar)")]
        public override ITransferible Move2(Transfer transfer)
        {
            base.Move2(transfer);

            MemoryType = (ERigVMMemoryType)transfer.Move((byte)MemoryType);

            transfer.Move(ref PropertyPathDescriptions);

            return this;
        }
    }
}
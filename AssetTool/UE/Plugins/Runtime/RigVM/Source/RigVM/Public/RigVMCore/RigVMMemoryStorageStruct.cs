namespace AssetTool
{
    public class FRigVMMemoryStorageStruct : FInstancedPropertyBag
    {
        public ERigVMMemoryType MemoryType;
        public List<FRigVMPropertyPathDescription> PropertyPathDescriptions;

        [Location("bool FRigVMMemoryStorageStruct::Serialize(FArchive& Ar)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.MoveEnum(ref MemoryType);
            transfer.Move(ref PropertyPathDescriptions);
            return this;
        }
    }
}
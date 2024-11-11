namespace AssetTool
{
    [JsonAsset("RigVMMemoryStorageGeneratorClass")]
    public class URigVMMemoryStorageGeneratorClass : UClass
    {
        public List<FRigVMPropertyPathDescription> PropertyPathDescriptions;
        public ERigVMMemoryType MemoryType;

        [Location("void URigVMMemoryStorageGeneratorClass::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyPathDescriptions);
            MemoryType = (ERigVMMemoryType)transfer.Move((byte)MemoryType);
            return this;
        }
    }

    [JsonAsset("RigVMMemoryStorage")]
    public class URigVMMemoryStorage : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
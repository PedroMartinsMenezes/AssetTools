namespace AssetTool
{
    [JsonAsset("RigVMMemoryStorageGeneratorClass")]
    public class URigVMMemoryStorageGeneratorClass : UClass
    {
        public List<FRigVMPropertyPathDescription> PropertyPathDescriptions;
        public ERigVMMemoryType MemoryType;

        [Location("void URigVMMemoryStorageGeneratorClass::Serialize(FArchive& Ar)")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PropertyPathDescriptions);
            transfer.MoveEnum(ref MemoryType);
            return this;
        }
    }

    [JsonAsset("RigVMMemoryStorage")]
    public class URigVMMemoryStorage : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
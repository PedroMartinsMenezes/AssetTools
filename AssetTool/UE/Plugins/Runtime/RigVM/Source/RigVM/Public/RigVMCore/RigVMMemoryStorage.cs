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
            if (transfer.GlobalObjects.CurrentObject.ObjectFlags.HasFlag(EObjectFlags.RF_ClassDefaultObject))
            {
                return SerializeDefaultObject(transfer);
            }

            base.Move(transfer);
            transfer.Move(ref PropertyPathDescriptions);
            transfer.MoveEnum(ref MemoryType);
            return this;
        }
    }
}
namespace AssetTool
{
    [JsonAsset("RigVMMemoryStorageGeneratorClass")]
    public class URigVMMemoryStorageGeneratorClass : UClass
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
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
namespace AssetTool
{
    [JsonAsset("RigVMEdGraphEnumNodeSpawner")]
    public class URigVMEdGraphEnumNodeSpawner : URigVMEdGraphNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
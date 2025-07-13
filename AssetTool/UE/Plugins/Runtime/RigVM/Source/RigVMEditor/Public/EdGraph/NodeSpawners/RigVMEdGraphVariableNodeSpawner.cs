namespace AssetTool
{
    [JsonAsset("RigVMEdGraphVariableNodeSpawner")]
    public class URigVMEdGraphVariableNodeSpawner : URigVMEdGraphNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
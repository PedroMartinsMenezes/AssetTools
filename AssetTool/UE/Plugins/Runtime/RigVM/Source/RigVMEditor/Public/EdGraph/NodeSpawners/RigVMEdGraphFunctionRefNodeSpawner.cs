namespace AssetTool
{
    [JsonAsset("RigVMEdGraphFunctionRefNodeSpawner")]
    public class URigVMEdGraphFunctionRefNodeSpawner : URigVMEdGraphNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
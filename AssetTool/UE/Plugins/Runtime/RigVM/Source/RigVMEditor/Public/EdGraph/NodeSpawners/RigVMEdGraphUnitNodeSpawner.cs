namespace AssetTool
{
    [JsonAsset("RigVMEdGraphUnitNodeSpawner")]
    public class URigVMEdGraphUnitNodeSpawner : URigVMEdGraphNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
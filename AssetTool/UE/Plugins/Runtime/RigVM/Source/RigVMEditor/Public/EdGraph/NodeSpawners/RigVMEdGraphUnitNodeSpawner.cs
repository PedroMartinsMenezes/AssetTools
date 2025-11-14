namespace AssetTool
{
    [JsonAsset("RigVMEdGraphUnitNodeSpawner")]
    public class URigVMEdGraphUnitNodeSpawner : URigVMEdGraphNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
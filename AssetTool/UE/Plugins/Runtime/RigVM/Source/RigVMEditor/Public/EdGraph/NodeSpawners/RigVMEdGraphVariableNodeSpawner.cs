namespace AssetTool
{
    [JsonAsset("RigVMEdGraphVariableNodeSpawner")]
    public class URigVMEdGraphVariableNodeSpawner : URigVMEdGraphNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("RigVMEdGraphTemplateNodeSpawner")]
    public class URigVMEdGraphTemplateNodeSpawner : URigVMEdGraphNodeSpawner
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
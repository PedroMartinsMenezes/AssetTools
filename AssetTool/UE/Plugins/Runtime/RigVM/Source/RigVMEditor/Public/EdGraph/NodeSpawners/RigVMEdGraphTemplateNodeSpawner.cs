namespace AssetTool
{
    [JsonAsset("RigVMEdGraphTemplateNodeSpawner")]
    public class URigVMEdGraphTemplateNodeSpawner : URigVMEdGraphNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
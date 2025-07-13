namespace AssetTool
{
    [JsonAsset("RigVMEdGraphNodeSpawner")]
    public class URigVMEdGraphNodeSpawner : UBlueprintNodeSpawner
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("RigVMEdGraph")]
    public class URigVMEdGraph : UEdGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("RigVMEdGraph")]
    public class URigVMEdGraph : UEdGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
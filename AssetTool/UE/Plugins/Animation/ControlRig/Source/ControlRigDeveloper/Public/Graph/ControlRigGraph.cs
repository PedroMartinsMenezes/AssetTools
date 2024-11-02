namespace AssetTool
{
    [JsonAsset("ControlRigGraph")]
    public class UControlRigGraph : URigVMEdGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
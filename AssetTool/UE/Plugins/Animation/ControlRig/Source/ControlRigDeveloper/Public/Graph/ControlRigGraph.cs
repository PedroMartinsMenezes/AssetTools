namespace AssetTool
{
    [JsonAsset("ControlRigGraph")]
    public class UControlRigGraph : URigVMEdGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
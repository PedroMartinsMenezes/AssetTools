namespace AssetTool
{
    [JsonAsset("ControlRigGraph")]
    public class UControlRigGraph : URigVMEdGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
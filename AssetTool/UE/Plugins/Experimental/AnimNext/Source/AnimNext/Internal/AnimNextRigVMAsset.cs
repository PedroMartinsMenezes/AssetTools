namespace AssetTool
{
    [JsonAsset("AnimNextRigVMAsset")]
    public class UAnimNextRigVMAsset : URigVMHost
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
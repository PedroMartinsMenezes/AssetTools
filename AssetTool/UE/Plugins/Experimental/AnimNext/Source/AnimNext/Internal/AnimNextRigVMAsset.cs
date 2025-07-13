namespace AssetTool
{
    [JsonAsset("AnimNextRigVMAsset")]
    public class UAnimNextRigVMAsset : URigVMHost
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
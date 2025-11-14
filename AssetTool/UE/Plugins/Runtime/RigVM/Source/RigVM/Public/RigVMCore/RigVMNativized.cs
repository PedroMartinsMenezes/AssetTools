namespace AssetTool
{
    [JsonAsset("RigVMNativized")]
    public class URigVMNativized : URigVM
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
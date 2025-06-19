namespace AssetTool
{
    [JsonAsset("RigVMNativized")]
    public class URigVMNativized : URigVM
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
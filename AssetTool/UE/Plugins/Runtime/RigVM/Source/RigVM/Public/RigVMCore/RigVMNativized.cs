namespace AssetTool
{
    [JsonAsset("RigVMNativized")]
    public class URigVMNativized : URigVM
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
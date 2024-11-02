namespace AssetTool
{
    [JsonAsset("RigVMFunctionLibrary")]
    public class URigVMFunctionLibrary : URigVMGraph
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
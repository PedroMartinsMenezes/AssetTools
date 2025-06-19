namespace AssetTool
{
    [JsonAsset("RigVMFunctionLibrary")]
    public class URigVMFunctionLibrary : URigVMGraph
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
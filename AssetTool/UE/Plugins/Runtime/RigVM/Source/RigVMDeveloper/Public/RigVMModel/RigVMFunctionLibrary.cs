namespace AssetTool
{
    [JsonAsset("RigVMFunctionLibrary")]
    public class URigVMFunctionLibrary : URigVMGraph
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
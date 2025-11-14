namespace AssetTool
{
    [JsonAsset("RigVMInjectionInfo")]
    public class URigVMInjectionInfo : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RigVMPin")]
    public class URigVMPin : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
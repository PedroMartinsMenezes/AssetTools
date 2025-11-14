namespace AssetTool
{
    [JsonAsset("RigVMController")]
    public class URigVMController : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RigVMControllerSettings")]
    public class URigVMControllerSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
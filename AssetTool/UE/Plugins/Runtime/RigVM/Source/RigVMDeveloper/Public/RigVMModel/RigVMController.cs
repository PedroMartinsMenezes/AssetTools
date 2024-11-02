namespace AssetTool
{
    [JsonAsset("RigVMController")]
    public class URigVMController : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RigVMControllerSettings")]
    public class URigVMControllerSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
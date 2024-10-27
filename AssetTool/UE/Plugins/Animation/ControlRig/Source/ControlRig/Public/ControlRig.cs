namespace AssetTool
{
    [JsonAsset("ControlRig")]
    public class  UControlRig : URigVMHost
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
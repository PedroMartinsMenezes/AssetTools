namespace AssetTool
{
    [JsonAsset("RigVMActionStack")]
    public class URigVMActionStack : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
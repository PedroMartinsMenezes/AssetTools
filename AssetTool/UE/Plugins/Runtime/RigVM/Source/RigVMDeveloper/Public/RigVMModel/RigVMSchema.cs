namespace AssetTool
{
    [JsonAsset("RigVMSchema")]
    public class URigVMSchema : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
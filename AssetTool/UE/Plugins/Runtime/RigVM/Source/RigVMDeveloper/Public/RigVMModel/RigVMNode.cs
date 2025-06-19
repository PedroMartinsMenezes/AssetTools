namespace AssetTool
{
    [JsonAsset("RigVMNode")]
    public class URigVMNode : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
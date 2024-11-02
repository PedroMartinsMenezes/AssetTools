namespace AssetTool
{
    [JsonAsset("RigVMNode")]
    public class URigVMNode : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
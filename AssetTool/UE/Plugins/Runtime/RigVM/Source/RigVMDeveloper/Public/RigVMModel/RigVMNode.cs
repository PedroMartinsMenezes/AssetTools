namespace AssetTool
{
    [JsonAsset("RigVMNode")]
    public class URigVMNode : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
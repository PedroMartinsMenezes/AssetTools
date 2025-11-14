namespace AssetTool
{
    [JsonAsset("RigVMBlueprint")]
    public class URigVMBlueprint : UBlueprint
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
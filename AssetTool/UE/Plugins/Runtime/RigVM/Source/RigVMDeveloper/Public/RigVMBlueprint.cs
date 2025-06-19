namespace AssetTool
{
    [JsonAsset("RigVMBlueprint")]
    public class URigVMBlueprint : UBlueprint
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
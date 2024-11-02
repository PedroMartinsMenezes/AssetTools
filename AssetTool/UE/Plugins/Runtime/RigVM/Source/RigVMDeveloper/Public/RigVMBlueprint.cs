namespace AssetTool
{
    [JsonAsset("RigVMBlueprint")]
    public class URigVMBlueprint : UBlueprint
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
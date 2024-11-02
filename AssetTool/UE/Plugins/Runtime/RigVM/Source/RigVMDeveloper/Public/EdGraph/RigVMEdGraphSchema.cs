namespace AssetTool
{
    [JsonAsset("RigVMEdGraphSchema")]
    public class URigVMEdGraphSchema : UEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
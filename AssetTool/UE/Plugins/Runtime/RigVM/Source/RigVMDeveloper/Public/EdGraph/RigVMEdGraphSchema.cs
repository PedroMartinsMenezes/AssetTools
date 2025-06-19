namespace AssetTool
{
    [JsonAsset("RigVMEdGraphSchema")]
    public class URigVMEdGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
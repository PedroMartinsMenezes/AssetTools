namespace AssetTool
{
    [JsonAsset("RigVMEdGraphSchema")]
    public class URigVMEdGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
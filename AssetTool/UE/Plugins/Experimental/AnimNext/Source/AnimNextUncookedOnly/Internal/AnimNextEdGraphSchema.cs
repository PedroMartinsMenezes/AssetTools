namespace AssetTool
{
    [JsonAsset("AnimNextEdGraphSchema")]
    public class UAnimNextEdGraphSchema : URigVMEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("DefaultWorkspaceSchema")]
    public class UDefaultWorkspaceSchema : UWorkspaceSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("WorkspaceSchema")]
    public class UWorkspaceSchema : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
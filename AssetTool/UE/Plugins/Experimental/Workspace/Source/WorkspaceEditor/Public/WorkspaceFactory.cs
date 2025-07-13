namespace AssetTool
{
    [JsonAsset("WorkspaceFactory")]
    public class UWorkspaceFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
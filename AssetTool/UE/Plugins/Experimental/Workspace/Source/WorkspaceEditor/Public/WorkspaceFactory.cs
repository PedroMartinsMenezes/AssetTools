namespace AssetTool
{
    [JsonAsset("WorkspaceFactory")]
    public class UWorkspaceFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
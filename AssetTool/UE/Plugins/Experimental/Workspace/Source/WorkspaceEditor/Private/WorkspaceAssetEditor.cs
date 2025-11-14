namespace AssetTool
{
    [JsonAsset("WorkspaceAssetEditor")]
    public class UWorkspaceAssetEditor : UAssetEditor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
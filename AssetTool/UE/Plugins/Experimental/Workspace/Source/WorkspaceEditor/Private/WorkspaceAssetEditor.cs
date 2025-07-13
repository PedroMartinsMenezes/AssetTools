namespace AssetTool
{
    [JsonAsset("WorkspaceAssetEditor")]
    public class UWorkspaceAssetEditor : UAssetEditor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("WorkspaceAssetEntry")]
    public class UWorkspaceAssetEntry : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
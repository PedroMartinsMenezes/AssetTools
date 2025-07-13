namespace AssetTool
{
    [JsonAsset("WorkspaceAssetEntry")]
    public class UWorkspaceAssetEntry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
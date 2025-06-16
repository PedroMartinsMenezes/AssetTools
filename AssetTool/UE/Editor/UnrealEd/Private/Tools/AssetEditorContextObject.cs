namespace AssetTool
{
    [JsonAsset("AssetEditorContextObject")]
    public class UAssetEditorContextObject : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
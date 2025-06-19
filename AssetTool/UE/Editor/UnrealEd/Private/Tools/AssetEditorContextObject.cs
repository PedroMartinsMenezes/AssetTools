namespace AssetTool
{
    [JsonAsset("AssetEditorContextObject")]
    public class UAssetEditorContextObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
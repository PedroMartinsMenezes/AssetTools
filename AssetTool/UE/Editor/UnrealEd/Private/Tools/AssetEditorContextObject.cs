namespace AssetTool
{
    [JsonAsset("AssetEditorContextObject")]
    public class UAssetEditorContextObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
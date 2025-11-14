namespace AssetTool
{
    [JsonAsset("SmartObjectAssetEditorSettings")]
    public class USmartObjectAssetEditorSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
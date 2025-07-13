namespace AssetTool
{
    [JsonAsset("SmartObjectAssetEditorSettings")]
    public class USmartObjectAssetEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("SmartObjectAssetEditor")]
    public class USmartObjectAssetEditor : UAssetEditor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("AutomatedAssetImportData")]
    public class UAutomatedAssetImportData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
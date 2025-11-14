namespace AssetTool
{
    [JsonAsset("AutomatedAssetImportData")]
    public class UAutomatedAssetImportData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
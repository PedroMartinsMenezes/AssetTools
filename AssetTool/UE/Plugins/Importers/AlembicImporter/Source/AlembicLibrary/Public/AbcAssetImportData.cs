namespace AssetTool
{
    [JsonAsset("AbcAssetImportData")]
    public class UAbcAssetImportData : UAssetImportData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
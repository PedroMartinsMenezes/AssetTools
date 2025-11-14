namespace AssetTool
{
    [JsonAsset("AbcAssetImportData")]
    public class UAbcAssetImportData : UAssetImportData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
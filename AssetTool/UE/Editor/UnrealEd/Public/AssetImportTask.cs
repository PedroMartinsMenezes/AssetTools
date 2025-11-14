namespace AssetTool
{
    [JsonAsset("AssetImportTask")]
    public class UAssetImportTask : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
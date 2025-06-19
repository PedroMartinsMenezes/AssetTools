namespace AssetTool
{
    [JsonAsset("AssetImportTask")]
    public class UAssetImportTask : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
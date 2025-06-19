namespace AssetTool
{
    [JsonAsset("AssetRegUtilCommandlet")]
    public class UAssetRegUtilCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("AssetRegistryDumpCommandlet")]
    public class UAssetRegistryDumpCommandlet : UCommandlet
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
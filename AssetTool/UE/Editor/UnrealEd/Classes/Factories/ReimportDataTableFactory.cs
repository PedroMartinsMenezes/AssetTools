namespace AssetTool
{
    [JsonAsset("ReimportDataTableFactory")]
    public class UReimportDataTableFactory : UCSVImportFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
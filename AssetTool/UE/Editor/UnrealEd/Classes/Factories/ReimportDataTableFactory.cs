namespace AssetTool
{
    [JsonAsset("ReimportDataTableFactory")]
    public class UReimportDataTableFactory : UCSVImportFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
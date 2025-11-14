namespace AssetTool
{
    [JsonAsset("ReimportDataTableFactory")]
    public class UReimportDataTableFactory : UCSVImportFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
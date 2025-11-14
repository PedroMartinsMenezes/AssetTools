namespace AssetTool
{
    [JsonAsset("CSVImportFactory")]
    public class UCSVImportFactory : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
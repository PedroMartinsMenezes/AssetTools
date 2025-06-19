namespace AssetTool
{
    [JsonAsset("CSVImportFactory")]
    public class UCSVImportFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
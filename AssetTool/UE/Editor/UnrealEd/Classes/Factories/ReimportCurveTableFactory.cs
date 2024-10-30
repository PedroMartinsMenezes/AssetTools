namespace AssetTool
{
    [JsonAsset("ReimportCurveTableFactory")]
    public class UReimportCurveTableFactory : UCSVImportFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ReimportCurveTableFactory")]
    public class UReimportCurveTableFactory : UCSVImportFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ReimportCurveFactory")]
    public class UReimportCurveFactory : UCSVImportFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ReimportCurveFactory")]
    public class UReimportCurveFactory : UCSVImportFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ReimportCurveFactory")]
    public class UReimportCurveFactory : UCSVImportFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
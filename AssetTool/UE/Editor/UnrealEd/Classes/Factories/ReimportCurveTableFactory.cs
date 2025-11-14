namespace AssetTool
{
    [JsonAsset("ReimportCurveTableFactory")]
    public class UReimportCurveTableFactory : UCSVImportFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
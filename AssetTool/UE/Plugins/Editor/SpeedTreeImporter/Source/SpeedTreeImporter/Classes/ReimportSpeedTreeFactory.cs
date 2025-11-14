namespace AssetTool
{
    [JsonAsset("ReimportSpeedTreeFactory")]
    public class UReimportSpeedTreeFactory : USpeedTreeImportFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
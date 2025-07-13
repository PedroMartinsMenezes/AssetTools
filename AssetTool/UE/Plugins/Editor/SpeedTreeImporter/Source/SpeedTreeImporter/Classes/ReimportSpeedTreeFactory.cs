namespace AssetTool
{
    [JsonAsset("ReimportSpeedTreeFactory")]
    public class UReimportSpeedTreeFactory : USpeedTreeImportFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
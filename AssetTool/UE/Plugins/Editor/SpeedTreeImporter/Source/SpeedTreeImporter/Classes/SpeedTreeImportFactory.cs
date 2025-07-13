namespace AssetTool
{
    [JsonAsset("SpeedTreeImportFactory")]
    public class USpeedTreeImportFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
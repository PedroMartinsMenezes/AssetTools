namespace AssetTool
{
    [JsonAsset("ProductionSettings")]
    public class UProductionSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
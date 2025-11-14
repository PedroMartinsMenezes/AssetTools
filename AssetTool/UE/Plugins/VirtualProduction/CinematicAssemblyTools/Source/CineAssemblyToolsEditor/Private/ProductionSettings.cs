namespace AssetTool
{
    [JsonAsset("ProductionSettings")]
    public class UProductionSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("WaterRuntimeSettings")]
    public class UWaterRuntimeSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
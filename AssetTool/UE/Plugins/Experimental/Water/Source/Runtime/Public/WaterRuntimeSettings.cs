namespace AssetTool
{
    [JsonAsset("WaterRuntimeSettings")]
    public class UWaterRuntimeSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
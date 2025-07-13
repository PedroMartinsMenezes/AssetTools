namespace AssetTool
{
    [JsonAsset("RazerChromaDevicesDeveloperSettings")]
    public class URazerChromaDevicesDeveloperSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
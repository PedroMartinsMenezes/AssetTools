namespace AssetTool
{
    [JsonAsset("RazerChromaDevicesDeveloperSettings")]
    public class URazerChromaDevicesDeveloperSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
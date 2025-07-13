namespace AssetTool
{
    [JsonAsset("ZoneGraphSettings")]
    public class UZoneGraphSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
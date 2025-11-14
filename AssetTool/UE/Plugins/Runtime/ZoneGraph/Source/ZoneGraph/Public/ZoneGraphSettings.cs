namespace AssetTool
{
    [JsonAsset("ZoneGraphSettings")]
    public class UZoneGraphSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
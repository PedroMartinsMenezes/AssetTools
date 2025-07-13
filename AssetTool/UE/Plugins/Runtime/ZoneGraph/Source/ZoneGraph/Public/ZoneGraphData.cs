namespace AssetTool
{
    [JsonAsset("ZoneGraphData")]
    public class AZoneGraphData : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
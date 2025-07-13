namespace AssetTool
{
    [JsonAsset("ZoneShape")]
    public class AZoneShape : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
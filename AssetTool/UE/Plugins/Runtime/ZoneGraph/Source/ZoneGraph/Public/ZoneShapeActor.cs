namespace AssetTool
{
    [JsonAsset("ZoneShape")]
    public class AZoneShape : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
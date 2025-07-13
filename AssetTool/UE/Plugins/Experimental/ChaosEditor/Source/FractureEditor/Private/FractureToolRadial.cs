namespace AssetTool
{
    [JsonAsset("FractureRadialSettings")]
    public class UFractureRadialSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolRadial")]
    public class UFractureToolRadial : UFractureToolVoronoiCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
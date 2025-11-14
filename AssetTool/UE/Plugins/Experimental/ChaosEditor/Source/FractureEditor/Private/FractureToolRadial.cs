namespace AssetTool
{
    [JsonAsset("FractureRadialSettings")]
    public class UFractureRadialSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolRadial")]
    public class UFractureToolRadial : UFractureToolVoronoiCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
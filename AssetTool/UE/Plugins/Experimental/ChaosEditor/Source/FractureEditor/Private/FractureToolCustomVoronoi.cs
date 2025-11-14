namespace AssetTool
{
    [JsonAsset("FractureCustomVoronoiSettings")]
    public class UFractureCustomVoronoiSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolCustomVoronoi")]
    public class UFractureToolCustomVoronoi : UFractureToolVoronoiCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
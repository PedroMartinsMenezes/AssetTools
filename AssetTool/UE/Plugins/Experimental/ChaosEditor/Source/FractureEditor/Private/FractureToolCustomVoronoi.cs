namespace AssetTool
{
    [JsonAsset("FractureCustomVoronoiSettings")]
    public class UFractureCustomVoronoiSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolCustomVoronoi")]
    public class UFractureToolCustomVoronoi : UFractureToolVoronoiCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
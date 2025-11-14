namespace AssetTool
{
    [JsonAsset("FractureClusterCutterSettings")]
    public class UFractureClusterCutterSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolClusterCutter")]
    public class UFractureToolClusterCutter : UFractureToolVoronoiCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
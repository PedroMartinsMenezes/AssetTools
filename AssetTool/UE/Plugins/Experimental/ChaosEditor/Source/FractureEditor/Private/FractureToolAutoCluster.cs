namespace AssetTool
{
    [JsonAsset("FractureAutoClusterSettings")]
    public class UFractureAutoClusterSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolAutoCluster")]
    public class UFractureToolAutoCluster : UFractureModalTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
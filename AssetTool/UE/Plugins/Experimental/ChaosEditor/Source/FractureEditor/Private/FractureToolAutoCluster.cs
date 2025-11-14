namespace AssetTool
{
    [JsonAsset("FractureAutoClusterSettings")]
    public class UFractureAutoClusterSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolAutoCluster")]
    public class UFractureToolAutoCluster : UFractureModalTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
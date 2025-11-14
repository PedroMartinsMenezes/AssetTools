namespace AssetTool
{
    [JsonAsset("FractureClusterMagnetSettings")]
    public class UFractureClusterMagnetSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolClusterMagnet")]
    public class UFractureToolClusterMagnet : UFractureModalTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
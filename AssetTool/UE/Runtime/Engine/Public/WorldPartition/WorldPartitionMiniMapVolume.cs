namespace AssetTool
{
    [JsonAsset("WorldPartitionMiniMapVolume")]
    public class AWorldPartitionMiniMapVolume : AVolume
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
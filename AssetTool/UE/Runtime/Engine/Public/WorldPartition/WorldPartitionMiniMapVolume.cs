namespace AssetTool
{
    [JsonAsset("WorldPartitionMiniMapVolume")]
    public class AWorldPartitionMiniMapVolume : AVolume
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
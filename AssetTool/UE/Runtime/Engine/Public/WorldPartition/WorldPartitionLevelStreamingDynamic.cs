namespace AssetTool
{
    [JsonAsset("WorldPartitionLevelStreamingDynamic")]
    public class UWorldPartitionLevelStreamingDynamic : ULevelStreamingDynamic
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
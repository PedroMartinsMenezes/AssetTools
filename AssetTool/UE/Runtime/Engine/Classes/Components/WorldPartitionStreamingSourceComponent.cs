namespace AssetTool
{
    [JsonAsset("WorldPartitionStreamingSourceComponent")]
    public class UWorldPartitionStreamingSourceComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
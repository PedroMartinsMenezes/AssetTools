namespace AssetTool
{
    [JsonAsset("WorldPartitionStreamingSourceComponent")]
    public class UWorldPartitionStreamingSourceComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
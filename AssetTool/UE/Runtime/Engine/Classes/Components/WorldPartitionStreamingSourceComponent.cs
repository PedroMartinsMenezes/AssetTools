namespace AssetTool
{
    [JsonAsset("WorldPartitionStreamingSourceComponent")]
    public class UWorldPartitionStreamingSourceComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
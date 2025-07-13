namespace AssetTool
{
    [JsonAsset("WorldPartitionPropertyOverride")]
    public class UWorldPartitionPropertyOverride : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionPropertyOverridePolicy")]
    public class UWorldPartitionPropertyOverridePolicy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
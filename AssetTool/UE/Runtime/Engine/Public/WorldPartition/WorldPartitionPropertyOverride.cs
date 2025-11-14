namespace AssetTool
{
    [JsonAsset("WorldPartitionPropertyOverride")]
    public class UWorldPartitionPropertyOverride : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WorldPartitionPropertyOverridePolicy")]
    public class UWorldPartitionPropertyOverridePolicy : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("WorldPartitionSubsystem")]
    public class UWorldPartitionSubsystem : UTickableWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
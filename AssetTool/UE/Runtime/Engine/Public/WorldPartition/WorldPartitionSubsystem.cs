namespace AssetTool
{
    [JsonAsset("WorldPartitionSubsystem")]
    public class UWorldPartitionSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
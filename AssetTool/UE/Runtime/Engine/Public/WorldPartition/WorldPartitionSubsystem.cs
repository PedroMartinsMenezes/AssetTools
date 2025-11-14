namespace AssetTool
{
    [JsonAsset("WorldPartitionSubsystem")]
    public class UWorldPartitionSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
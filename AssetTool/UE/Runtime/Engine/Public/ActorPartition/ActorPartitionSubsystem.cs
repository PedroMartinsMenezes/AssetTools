namespace AssetTool
{
    [JsonAsset("ActorPartitionSubsystem")]
    public class UActorPartitionSubsystem : UWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
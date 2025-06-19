namespace AssetTool
{
    [JsonAsset("ActorPartitionSubsystem")]
    public class UActorPartitionSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
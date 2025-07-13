namespace AssetTool
{
    [JsonAsset("ActorDescContainerSubsystem")]
    public class UActorDescContainerSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
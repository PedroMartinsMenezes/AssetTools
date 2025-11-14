namespace AssetTool
{
    [JsonAsset("ActorDescContainerSubsystem")]
    public class UActorDescContainerSubsystem : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
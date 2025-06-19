namespace AssetTool
{
    [JsonAsset("ActorModifierCoreSubsystem")]
    public class UActorModifierCoreSubsystem : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
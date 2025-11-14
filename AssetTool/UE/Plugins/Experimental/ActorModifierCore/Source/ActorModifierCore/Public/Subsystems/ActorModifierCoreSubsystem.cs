namespace AssetTool
{
    [JsonAsset("ActorModifierCoreSubsystem")]
    public class UActorModifierCoreSubsystem : UEngineSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ActorModifierCoreSharedActor")]
    public class AActorModifierCoreSharedActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
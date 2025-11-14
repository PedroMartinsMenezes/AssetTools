namespace AssetTool
{
    [JsonAsset("ActorModifierCoreSharedActor")]
    public class AActorModifierCoreSharedActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
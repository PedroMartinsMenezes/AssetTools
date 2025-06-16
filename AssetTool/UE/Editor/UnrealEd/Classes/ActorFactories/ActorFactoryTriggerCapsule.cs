namespace AssetTool
{
    [JsonAsset("ActorFactoryTriggerCapsule")]
    public class UActorFactoryTriggerCapsule : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
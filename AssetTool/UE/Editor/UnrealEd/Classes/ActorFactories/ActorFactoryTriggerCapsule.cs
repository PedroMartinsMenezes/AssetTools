namespace AssetTool
{
    [JsonAsset("ActorFactoryTriggerCapsule")]
    public class UActorFactoryTriggerCapsule : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
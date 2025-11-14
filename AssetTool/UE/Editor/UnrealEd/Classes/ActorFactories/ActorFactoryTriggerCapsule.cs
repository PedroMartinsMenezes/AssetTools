namespace AssetTool
{
    [JsonAsset("ActorFactoryTriggerCapsule")]
    public class UActorFactoryTriggerCapsule : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
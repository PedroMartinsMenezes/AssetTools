namespace AssetTool
{
    [JsonAsset("ActorFactoryTriggerBox")]
    public class UActorFactoryTriggerBox : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
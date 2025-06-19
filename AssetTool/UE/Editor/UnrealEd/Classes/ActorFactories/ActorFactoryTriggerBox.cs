namespace AssetTool
{
    [JsonAsset("ActorFactoryTriggerBox")]
    public class UActorFactoryTriggerBox : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
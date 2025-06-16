namespace AssetTool
{
    [JsonAsset("ActorFactoryTriggerBox")]
    public class UActorFactoryTriggerBox : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
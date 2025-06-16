namespace AssetTool
{
    [JsonAsset("ActorFactoryTriggerSphere")]
    public class UActorFactoryTriggerSphere : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ActorFactoryTriggerSphere")]
    public class UActorFactoryTriggerSphere : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ActorFactoryTriggerSphere")]
    public class UActorFactoryTriggerSphere : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
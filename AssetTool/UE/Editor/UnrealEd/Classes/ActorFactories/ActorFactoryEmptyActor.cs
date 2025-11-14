namespace AssetTool
{
    [JsonAsset("ActorFactoryEmptyActor")]
    public class UActorFactoryEmptyActor : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
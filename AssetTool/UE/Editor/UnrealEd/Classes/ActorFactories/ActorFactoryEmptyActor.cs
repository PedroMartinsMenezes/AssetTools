namespace AssetTool
{
    [JsonAsset("ActorFactoryEmptyActor")]
    public class UActorFactoryEmptyActor : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
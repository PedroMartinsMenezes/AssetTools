namespace AssetTool
{
    [JsonAsset("ActorFactoryEmptyActor")]
    public class UActorFactoryEmptyActor : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
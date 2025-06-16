namespace AssetTool
{
    [JsonAsset("ActorFactoryEmitter")]
    public class UActorFactoryEmitter : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
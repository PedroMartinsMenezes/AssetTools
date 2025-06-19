namespace AssetTool
{
    [JsonAsset("ActorFactoryDeferredDecal")]
    public class UActorFactoryDeferredDecal : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
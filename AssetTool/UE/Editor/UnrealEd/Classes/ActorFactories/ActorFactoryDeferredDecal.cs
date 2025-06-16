namespace AssetTool
{
    [JsonAsset("ActorFactoryDeferredDecal")]
    public class UActorFactoryDeferredDecal : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
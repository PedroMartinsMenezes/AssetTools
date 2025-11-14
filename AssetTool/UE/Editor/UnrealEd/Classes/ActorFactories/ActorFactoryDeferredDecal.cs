namespace AssetTool
{
    [JsonAsset("ActorFactoryDeferredDecal")]
    public class UActorFactoryDeferredDecal : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
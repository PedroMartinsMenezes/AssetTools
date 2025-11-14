namespace AssetTool
{
    [JsonAsset("MediaBundleFactoryNew")]
    public class UMediaBundleFactoryNew : UFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ActorFactoryMediaBundle")]
    public class UActorFactoryMediaBundle : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
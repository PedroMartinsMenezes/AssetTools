namespace AssetTool
{
    [JsonAsset("ActorFactoryLandscape")]
    public class UActorFactoryLandscape : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
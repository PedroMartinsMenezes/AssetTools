namespace AssetTool
{
    [JsonAsset("ActorFactoryLandscape")]
    public class UActorFactoryLandscape : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
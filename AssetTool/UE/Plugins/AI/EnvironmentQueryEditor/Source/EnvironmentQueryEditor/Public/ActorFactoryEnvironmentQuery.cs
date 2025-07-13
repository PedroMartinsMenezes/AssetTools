namespace AssetTool
{
    [JsonAsset("ActorFactoryEnvironmentQuery")]
    public class UActorFactoryEnvironmentQuery : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ActorFactoryChaosSolver")]
    public class UActorFactoryChaosSolver : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
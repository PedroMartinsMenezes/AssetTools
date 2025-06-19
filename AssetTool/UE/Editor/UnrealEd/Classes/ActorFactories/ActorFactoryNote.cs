namespace AssetTool
{
    [JsonAsset("ActorFactoryNote")]
    public class UActorFactoryNote : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
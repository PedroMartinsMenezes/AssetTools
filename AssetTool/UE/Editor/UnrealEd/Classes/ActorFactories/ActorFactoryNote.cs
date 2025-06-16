namespace AssetTool
{
    [JsonAsset("ActorFactoryNote")]
    public class UActorFactoryNote : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ActorFactoryCacheManager")]
    public class UActorFactoryCacheManager : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
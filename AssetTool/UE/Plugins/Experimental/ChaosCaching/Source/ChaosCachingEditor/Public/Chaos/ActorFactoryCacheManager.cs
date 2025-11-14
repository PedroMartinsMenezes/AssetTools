namespace AssetTool
{
    [JsonAsset("ActorFactoryCacheManager")]
    public class UActorFactoryCacheManager : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
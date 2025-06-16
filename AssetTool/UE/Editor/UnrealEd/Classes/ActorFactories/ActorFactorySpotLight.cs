namespace AssetTool
{
    [JsonAsset("ActorFactorySpotLight")]
    public class UActorFactorySpotLight : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
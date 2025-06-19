namespace AssetTool
{
    [JsonAsset("ActorFactorySpotLight")]
    public class UActorFactorySpotLight : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
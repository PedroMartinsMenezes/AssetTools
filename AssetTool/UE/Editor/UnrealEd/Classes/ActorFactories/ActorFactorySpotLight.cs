namespace AssetTool
{
    [JsonAsset("ActorFactorySpotLight")]
    public class UActorFactorySpotLight : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
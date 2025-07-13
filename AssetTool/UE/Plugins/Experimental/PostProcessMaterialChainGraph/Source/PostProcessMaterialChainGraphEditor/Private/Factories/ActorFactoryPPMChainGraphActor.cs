namespace AssetTool
{
    [JsonAsset("ActorFactoryPPMChainGraphActor")]
    public class UActorFactoryPPMChainGraphActor : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
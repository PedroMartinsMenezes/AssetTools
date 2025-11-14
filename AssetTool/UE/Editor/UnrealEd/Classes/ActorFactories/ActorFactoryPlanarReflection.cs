namespace AssetTool
{
    [JsonAsset("ActorFactoryPlanarReflection")]
    public class UActorFactoryPlanarReflection : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
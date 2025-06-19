namespace AssetTool
{
    [JsonAsset("ActorFactoryPlanarReflection")]
    public class UActorFactoryPlanarReflection : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
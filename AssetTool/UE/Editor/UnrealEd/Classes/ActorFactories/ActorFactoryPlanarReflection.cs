namespace AssetTool
{
    [JsonAsset("ActorFactoryPlanarReflection")]
    public class UActorFactoryPlanarReflection : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
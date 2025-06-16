namespace AssetTool
{
    [JsonAsset("ActorFactoryCameraActor")]
    public class UActorFactoryCameraActor : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
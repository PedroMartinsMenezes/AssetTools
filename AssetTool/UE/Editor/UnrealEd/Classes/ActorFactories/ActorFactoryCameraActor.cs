namespace AssetTool
{
    [JsonAsset("ActorFactoryCameraActor")]
    public class UActorFactoryCameraActor : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
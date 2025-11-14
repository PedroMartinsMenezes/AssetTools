namespace AssetTool
{
    [JsonAsset("ActorFactoryCameraActor")]
    public class UActorFactoryCameraActor : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ActorFactoryPlaneReflectionCapture")]
    public class UActorFactoryPlaneReflectionCapture : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
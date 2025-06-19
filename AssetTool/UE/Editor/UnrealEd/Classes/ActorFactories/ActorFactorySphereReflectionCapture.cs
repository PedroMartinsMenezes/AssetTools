namespace AssetTool
{
    [JsonAsset("ActorFactorySphereReflectionCapture")]
    public class UActorFactorySphereReflectionCapture : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
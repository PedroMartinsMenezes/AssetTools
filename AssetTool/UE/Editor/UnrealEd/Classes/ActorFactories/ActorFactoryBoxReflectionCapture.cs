namespace AssetTool
{
    [JsonAsset("ActorFactoryBoxReflectionCapture")]
    public class UActorFactoryBoxReflectionCapture : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
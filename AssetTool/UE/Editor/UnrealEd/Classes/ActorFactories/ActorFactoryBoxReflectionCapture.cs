namespace AssetTool
{
    [JsonAsset("ActorFactoryBoxReflectionCapture")]
    public class UActorFactoryBoxReflectionCapture : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
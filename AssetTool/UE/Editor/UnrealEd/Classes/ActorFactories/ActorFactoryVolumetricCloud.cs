namespace AssetTool
{
    [JsonAsset("ActorFactoryVolumetricCloud")]
    public class UActorFactoryVolumetricCloud : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
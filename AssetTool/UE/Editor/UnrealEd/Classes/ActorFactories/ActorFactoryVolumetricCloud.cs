namespace AssetTool
{
    [JsonAsset("ActorFactoryVolumetricCloud")]
    public class UActorFactoryVolumetricCloud : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
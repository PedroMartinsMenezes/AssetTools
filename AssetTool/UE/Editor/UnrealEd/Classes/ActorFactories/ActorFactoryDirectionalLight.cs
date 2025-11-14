namespace AssetTool
{
    [JsonAsset("ActorFactoryDirectionalLight")]
    public class UActorFactoryDirectionalLight : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
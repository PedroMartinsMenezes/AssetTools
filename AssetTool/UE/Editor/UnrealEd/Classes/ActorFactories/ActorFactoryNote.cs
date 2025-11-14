namespace AssetTool
{
    [JsonAsset("ActorFactoryNote")]
    public class UActorFactoryNote : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
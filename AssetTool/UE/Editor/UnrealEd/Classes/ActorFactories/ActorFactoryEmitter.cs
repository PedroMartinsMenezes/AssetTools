namespace AssetTool
{
    [JsonAsset("ActorFactoryEmitter")]
    public class UActorFactoryEmitter : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ActorFactoryEmitter")]
    public class UActorFactoryEmitter : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
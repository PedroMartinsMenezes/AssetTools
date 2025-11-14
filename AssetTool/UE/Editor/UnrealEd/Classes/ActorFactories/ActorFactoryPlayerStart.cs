namespace AssetTool
{
    [JsonAsset("ActorFactoryPlayerStart")]
    public class UActorFactoryPlayerStart : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
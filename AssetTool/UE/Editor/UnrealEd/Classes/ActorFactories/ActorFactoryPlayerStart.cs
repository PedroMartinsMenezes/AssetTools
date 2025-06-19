namespace AssetTool
{
    [JsonAsset("ActorFactoryPlayerStart")]
    public class UActorFactoryPlayerStart : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
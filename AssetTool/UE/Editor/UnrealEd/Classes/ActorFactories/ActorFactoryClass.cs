namespace AssetTool
{
    [JsonAsset("ActorFactoryClass")]
    public class UActorFactoryClass : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
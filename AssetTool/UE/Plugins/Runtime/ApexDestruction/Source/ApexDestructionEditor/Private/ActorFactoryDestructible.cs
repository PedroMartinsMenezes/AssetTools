namespace AssetTool
{
    [JsonAsset("ActorFactoryDestructible")]
    public class UActorFactoryDestructible : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
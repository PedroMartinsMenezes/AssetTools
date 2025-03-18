namespace AssetTool
{
    [JsonAsset("ActorFactoryDestructible")]
    public class UActorFactoryDestructible : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
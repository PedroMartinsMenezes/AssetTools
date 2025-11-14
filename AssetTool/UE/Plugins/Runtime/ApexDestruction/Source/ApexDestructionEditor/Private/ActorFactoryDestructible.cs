namespace AssetTool
{
    [JsonAsset("ActorFactoryDestructible")]
    public class UActorFactoryDestructible : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
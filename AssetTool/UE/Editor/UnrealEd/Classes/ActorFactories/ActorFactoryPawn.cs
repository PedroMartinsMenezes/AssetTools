namespace AssetTool
{
    [JsonAsset("ActorFactoryPawn")]
    public class UActorFactoryPawn : UActorFactoryEmptyActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
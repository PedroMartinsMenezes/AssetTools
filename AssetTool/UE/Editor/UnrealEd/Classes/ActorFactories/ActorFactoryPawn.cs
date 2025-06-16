namespace AssetTool
{
    [JsonAsset("ActorFactoryPawn")]
    public class UActorFactoryPawn : UActorFactoryEmptyActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
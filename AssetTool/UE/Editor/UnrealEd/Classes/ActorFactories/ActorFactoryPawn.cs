namespace AssetTool
{
    [JsonAsset("ActorFactoryPawn")]
    public class UActorFactoryPawn : UActorFactoryEmptyActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
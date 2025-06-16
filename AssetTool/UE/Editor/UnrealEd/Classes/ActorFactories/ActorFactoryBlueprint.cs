namespace AssetTool
{
    [JsonAsset("ActorFactoryBlueprint")]
    public class UActorFactoryBlueprint : UActorFactory
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
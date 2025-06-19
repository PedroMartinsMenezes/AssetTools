namespace AssetTool
{
    [JsonAsset("ActorFactoryBlueprint")]
    public class UActorFactoryBlueprint : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
namespace AssetTool
{
    [JsonAsset("ActorFactoryBlueprint")]
    public class UActorFactoryBlueprint : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
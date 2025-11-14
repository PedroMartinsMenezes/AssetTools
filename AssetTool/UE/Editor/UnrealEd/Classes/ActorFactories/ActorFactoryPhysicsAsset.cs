namespace AssetTool
{
    [JsonAsset("ActorFactoryPhysicsAsset")]
    public class UActorFactoryPhysicsAsset : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}